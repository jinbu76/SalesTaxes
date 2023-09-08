namespace SalesTaxes.Domains.Product.Domain.Aggregate;

public class ProductAggregate
{
    public Guid Id { get; private set; } 
    public string Name { get; private set; } 
    public double Price { get; private set; }
    public bool IsImported { get; private set; }
    public CategoryAggregate Category { get; private set; }
    public Guid CategoryId { get; private set; }
}