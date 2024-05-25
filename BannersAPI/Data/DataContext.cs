using BannersAPI.Entity;
using Microsoft.EntityFrameworkCore;
//ეს არის აღწერა, იმის, თუ როგორ უნდა ვმუშავოთ ბაზასათან.
namespace BannersAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Banners> Banners => Set<Banners>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<category>().HasKey(e => e.id);
            modelBuilder.Entity<Banners>().HasKey(e => e.Id);
        }
    }
}
