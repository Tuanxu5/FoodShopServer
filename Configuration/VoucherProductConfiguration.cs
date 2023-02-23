using foodshop.Modal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Configuration
{
    public class VoucherProductConfiguration : IEntityTypeConfiguration<VoucherProduct>
    {
        public void Configure(EntityTypeBuilder<VoucherProduct> builder)
        {
            builder.ToTable("VoucherProduct");
            builder.HasKey(pc => pc.id);
            builder.Property(pc => pc.voucher_id);
            builder.Property(pc => pc.product_id);
            builder.Property(pc => pc.created_at);
            builder.Property(pc => pc.updated_at);
        }
    }
}
