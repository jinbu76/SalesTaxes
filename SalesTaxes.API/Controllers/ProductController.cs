using Microsoft.AspNetCore.Mvc;
using SalesTaxes.Domains.Product.ServiceDefinition;
using SalesTaxes.Domains.Product.ServiceDefinition.Models;

namespace SalesTaxes.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController: ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<List<ProductDto>> GetAllProducts()
    {
        return await _productService.GetAllProducts();
    }
}