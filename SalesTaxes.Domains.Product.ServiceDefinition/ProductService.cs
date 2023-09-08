using SalesTaxes.Domains.Product.Domain;
using SalesTaxes.Domains.Product.ServiceDefinition.Models;

namespace SalesTaxes.Domains.Product.ServiceDefinition;

public class ProductService: IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<ProductDto>> GetAllProducts()
    {
        var products = await _productRepository.GetAllProducts();
        var productDtos = products.Select(p =>
            new ProductDto(p.Id, p.Name, p.Price, p.IsImported, p.Category.TaxPercent, p.Category.DutyFree)).ToList();
        return productDtos;
    }
}