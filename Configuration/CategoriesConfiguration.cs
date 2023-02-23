using foodshop.Modal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Configuration
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(pc => pc.id);
            builder.Property(pc => pc.categories_name);
            builder.Property(pc => pc.categories_status);
            builder.Property(pc => pc.created_at);
            builder.Property(pc => pc.updated_at);
        }
    }
}
