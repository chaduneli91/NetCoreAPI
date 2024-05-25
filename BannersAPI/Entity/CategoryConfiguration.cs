using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BannersAPI.Entity
{
    public class CategoryConfiguration : IEntityTypeConfiguration<category>
    {
        public void Configure(EntityTypeBuilder<category> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
