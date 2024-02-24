using CodeMe.Pro.Dto;
using CodeMePro.Services;
using Microsoft.AspNetCore.Mvc;


namespace CodeMePro.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductService _productService; 

    public ProductController(ILogger<ProductController> logger, IProductService productService) 
    {
        _logger = logger;
        _productService = productService; 
    }

    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll() 
    {
      var products = await _productService.GetAllProductsAsync(); 
            if (products == null || !products.Any()) 
            {
                return NotFound("No products found.");
            }
            return Ok(products); 
    }
}
