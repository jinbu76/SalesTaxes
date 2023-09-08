using SalesTaxes.Domains.Product.Domain.Aggregate;

namespace SalesTaxes.Domains.Product.Domain;

public interface IProductRepository
{
    Task<List<ProductAggregate>> GetAllProducts();
}