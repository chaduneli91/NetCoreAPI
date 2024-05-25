using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BannersAPI.Entity
{
    public class ProductConfiguration : IEntityTypeConfiguration<product>
    {
        public void Configure(EntityTypeBuilder<product> builder)
        {
          

            builder.HasKey(e => e.Id);
            builder.HasOne(b => b.category);
        }
    }
}
