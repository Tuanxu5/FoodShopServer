using foodshop.Modal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(pc => pc.id);
            builder.Property(pc => pc.product_image);
            builder.Property(pc => pc.product_name);
            builder.Property(pc => pc.product_price);
            builder.Property(pc => pc.product_vote);
            builder.Property(pc => pc.product_love);
            builder.Property(pc => pc.product_view);
            builder.Property(pc => pc.product_status);
            builder.Property(pc => pc.product_description);
            builder.Property(pc => pc.store_id);
            builder.Property(pc => pc.product_category_id);
            builder.Property(pc => pc.created_at);
            builder.Property(pc => pc.updated_at);
            builder.Property(pc => pc.product_code);
        }
    }
}
