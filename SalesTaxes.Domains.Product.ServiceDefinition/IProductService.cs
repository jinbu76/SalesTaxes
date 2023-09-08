using SalesTaxes.Domains.Product.ServiceDefinition.Models;

namespace SalesTaxes.Domains.Product.ServiceDefinition;

public interface IProductService
{
    Task<List<ProductDto>> GetAllProducts();
}