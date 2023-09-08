namespace SalesTaxes.Domains.Product.Domain.Aggregate;

public class CategoryAggregate
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } 
    public short TaxPercent { get; private set; } 
    public short DutyFree { get; private set; }
    public List<ProductAggregate> Products { get; private set; }
}