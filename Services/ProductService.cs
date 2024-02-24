using CodeMe.Pro.Models;
using CodeMePro.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CodeMePro.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _unitOfWork.GenericRepository.GetAll<Product>().ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _unitOfWork.GenericRepository.GetByIdAsync<Product>(id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product with ID {id} not found.");
            }
            return product;
        }
    }
}
