using BannersAPI.Entity;
using Microsoft.EntityFrameworkCore;

namespace BannersAPI
{
    public class ProductManagmentContext : DbContext
    {
        public DbSet<category> Categories { get; set; }
        public DbSet<product> Products { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageProduct> PackagesProducts { get; set; }

        public ProductManagmentContext() { }

        public ProductManagmentContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PackageConfiguration());
            modelBuilder.ApplyConfiguration(new PackageProductConfiguration());
        }
    }
}