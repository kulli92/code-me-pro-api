
using CodeMe.Pro.Dto;

namespace CodeMePro.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDto>> GetAllOrdersAsync();
        Task<OrderDto> GetOrderByIdAsync(int id);
        Task<OrderDto> CreateOrderAsync(IEnumerable<ProductDto> selectedProducts);
    }
}

