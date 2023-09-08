using Microsoft.EntityFrameworkCore;
using SalesTaxes.Domains.Product.Domain.Aggregate;

namespace SalesTaxes.Domains.Product.Infrastructure;

public class ProductDbContext: DbContext
{
    public DbSet<ProductAggregate> Products { get; set; }
    public DbSet<CategoryAggregate> Categories { get; set; }
    
    public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductAggregate>().ToTable("Product");
        modelBuilder.Entity<ProductAggregate>().HasKey(p => p.Id);
        modelBuilder.Entity<ProductAggregate>().Property(p => p.Name).IsRequired();
        modelBuilder.Entity<ProductAggregate>().HasOne(p => p.Category)
            .WithMany(c => c.Products).HasForeignKey(p => p.CategoryId)
            .HasPrincipalKey(c => c.Id);
        
        
        modelBuilder.Entity<CategoryAggregate>().ToTable("Category");
        modelBuilder.Entity<CategoryAggregate>().HasKey(p => p.Id);
        
        base.OnModelCreating(modelBuilder);
    }
}
