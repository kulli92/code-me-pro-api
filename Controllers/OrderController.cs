using CodeMe.Pro.Dto;
using CodeMe.Pro.Models;
using CodeMePro.Services;
using Microsoft.AspNetCore.Mvc;


namespace CodeMePro.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly ILogger<OrderController> _logger;
    private readonly IOrderService _OrderService; 
    public OrderController(ILogger<OrderController> logger, IOrderService OrderService) 
    {
        _logger = logger;
        _OrderService = OrderService; 
    }

    [HttpPost("")]
    public async Task<ActionResult<OrderDto>> PlaceOrder(IEnumerable<ProductDto> selectedOrders) 
    {
       var placedOrder = await _OrderService.CreateOrderAsync(selectedOrders);
       return Ok(placedOrder?? null); 
    }
}
