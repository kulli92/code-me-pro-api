using CodeMe.Pro.Models;
using CodeMe.Pro.SeedData;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Package> Package { get; set; }
    public DbSet<PackageDetail> PackageDetail { get; set; }
    public DbSet<OrderDetail> OrderDetail { get; set; }
    public DbSet<CourierCharge> CourierCharge { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(ProductSeedData.GetProducts());

        modelBuilder.Entity<CourierCharge>().HasData(CourierChargeSeedData.GetCourierCharges());
    }
}
