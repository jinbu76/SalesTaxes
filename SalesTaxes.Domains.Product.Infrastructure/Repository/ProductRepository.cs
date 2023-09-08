using SalesTaxes.Domains.Product.Domain;
using SalesTaxes.Domains.Product.Domain.Aggregate;

namespace SalesTaxes.Domains.Product.Infrastructure.Repository;

public class ProductRepository: IProductRepository
{
    private readonly ProductDbContext _productDb;

    public ProductRepository(ProductDbContext productDb)
    {
        _productDb = productDb;
    }

    public async Task<List<ProductAggregate>> GetAllProducts()
    {
        var products = _productDb.Products.ToList();
        var categories = _productDb.Categories.ToList();
        return products;
    }
}