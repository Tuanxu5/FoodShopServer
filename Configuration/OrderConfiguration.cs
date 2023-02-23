using foodshop.Modal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(pc => pc.id);
            builder.Property(pc => pc.user_name);
            builder.Property(pc => pc.number_phone);
            builder.Property(pc => pc.order_city);
            builder.Property(pc => pc.order_district);
            builder.Property(pc => pc.address_detail);
            builder.Property(pc => pc.shipping);
            builder.Property(pc => pc.payment);
            builder.Property(pc => pc.order_status);
            builder.Property(pc => pc.total);
            builder.Property(pc => pc.created_at);
            builder.Property(pc => pc.updated_at);
            builder.Property(pc => pc.store_id);
            builder.Property(pc => pc.id_users);
        }
    }
}
