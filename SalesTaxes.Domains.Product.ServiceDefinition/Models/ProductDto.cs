namespace SalesTaxes.Domains.Product.ServiceDefinition.Models;

public class ProductDto
{
    public Guid Id { get; private set; } 
    public string Name { get; private set; } 
    public double Price { get; private set; }
    public bool IsImported { get; private set; } 
    public short Taxes { get; private set; } 
    public short DutyFree { get; private set; } 

    public ProductDto(Guid id, string name, double price, bool isImported, short taxes, short dutyFree)
    {
        Id = id;
        Name = name;
        IsImported = isImported;
        Taxes = taxes;
        DutyFree = dutyFree;
        Price = price;
    }
}