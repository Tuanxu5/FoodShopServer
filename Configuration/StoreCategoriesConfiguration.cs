using foodshop.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace foodshop.Configuration
{
    public class StoreCategoriesConfiguration: IEntityTypeConfiguration<StoreCategories>
    {
        public void Configure(EntityTypeBuilder<StoreCategories> builder)
        {
            builder.ToTable("StoreCategories");
            builder.HasKey(pc => pc.id);
            builder.Property(pc => pc.store_id);
            builder.Property(pc => pc.categories_id);
        }
    }
}
