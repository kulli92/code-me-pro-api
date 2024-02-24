using System.Runtime.Serialization;
using CodeMe.Pro.Dto;
using CodeMe.Pro.Models;
using CodeMePro.Repositories;

namespace CodeMePro.Services
{
    public class OrderService : IOrderService
    {
        private const decimal MaxPricePerPackage = 249m;

        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<OrderDto>> GetAllOrdersAsync()
        {
            return new List<OrderDto>();
        }

        public async Task<OrderDto> GetOrderByIdAsync(int id)
        {
            var order = await _unitOfWork.GenericRepository.GetByIdAsync<Order>(id);
            if (order == null)
            {
                throw new KeyNotFoundException($"Order with ID {id} not found.");
            }
            return new OrderDto();
        }

        public async Task<OrderDto> CreateOrderAsync(IEnumerable<ProductDto> selectedProducts)
        {
            if (!selectedProducts.Any())
            {
                throw new ArgumentNullException(nameof(selectedProducts), "Order cannot be Empty.");
            }

            var productsDb = _unitOfWork
                .GenericRepository.GetAll<Product>()
                .Where(x => selectedProducts.Select(x => x.ProductId).Contains(x.ProductId));

            var order = new Order
            {
                Packages = DistributeDistribute(productsDb.ToList()),
                OrderDetails = MapProductsOrder(productsDb)
            };

            await _unitOfWork.GenericRepository.AddAsync(order);
            await _unitOfWork.SaveChangesAsync();
            return new OrderDto
            {
                OrderDate = order.OrderDate,
                Packages = order.Packages.Select(x => new PackageDto
                {
                    PackageId = x.PackageId,
                    CourierPrice = x.CourierPrice,
                    ProductNames = x.PackageDetails.Select(y => y.Product.Name).ToList()
                }).ToList()
            };

        }

        private ICollection<OrderDetail> MapProductsOrder(IEnumerable<Product> selectedProducts)
        {
            return selectedProducts.Select(x => new OrderDetail
            {
                Product = x

            }).ToList();
        }

        private List<Package> DistributeDistribute(List<Product> products)
        {
            decimal totalPrice = products.Sum(item => item.Price);
            int totalWeight = products.Sum(item => item.Weight);
            int numberOfPackages = (int)Math.Ceiling(totalPrice / MaxPricePerPackage);
            int optimalWeightPerPackage = totalWeight / numberOfPackages;

            var courierPrices = _unitOfWork.GenericRepository.GetAll<CourierCharge>().ToList();

            List<Package> packages = Enumerable
                .Range(0, numberOfPackages)
                .Select(_ => new Package())
                .ToList();

            // Sort products by weight in descending order as a starting strategy
            products = products.OrderByDescending(item => item.Weight).ToList();

            foreach (var item in products)
            {
                // Try to add item to a package where it fits the best
                // Prioritize by package's closeness to optimal weight and then by not exceeding max price
                var bestPackage = packages
                    .Where(p => p.TotalPrice + item.Price <= MaxPricePerPackage)
                    .OrderBy(p => Math.Abs(optimalWeightPerPackage - (p.TotalWeight + item.Weight))) // Closest to optimal weight
                    .ThenBy(p => p.TotalPrice + item.Price) // Least increase in price
                    .FirstOrDefault();



                if (bestPackage != null)
                {
                    var addedItem = new PackageDetail { Product = item };
                    bestPackage.TotalPrice += item.Price;
                    bestPackage.TotalWeight += item.Weight;

                    // Add the item to the best fitting package
                    bestPackage?.PackageDetails.Add(addedItem);
                }
            }

            foreach (var package in packages)
            {
                package.TotalWeight = package.PackageDetails.Sum(x => x.Product.Weight);
                package.TotalPrice = package.PackageDetails.Sum(x => x.Product.Price);
                package.CourierPrice = courierPrices
                .FirstOrDefault(x => package.TotalWeight >= x.MinWeight && package.TotalWeight <= x.MaxWeight)?.Charge ?? default;
            }

            return packages;
        }
    }
}
