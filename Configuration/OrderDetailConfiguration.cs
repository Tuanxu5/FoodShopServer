using foodshop.Modal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Configuration
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");
            builder.HasKey(pc => pc.id);
            builder.Property(pc => pc.product_id);
            builder.Property(pc => pc.product_name);
            builder.Property(pc => pc.product_image);
            builder.Property(pc => pc.order_id);
            builder.Property(pc => pc.price);
            builder.Property(pc => pc.quality);
            builder.Property(pc => pc.created_at);
            builder.Property(pc => pc.updated_at);
        }
    }
}
