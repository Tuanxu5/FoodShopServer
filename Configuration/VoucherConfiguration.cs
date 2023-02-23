using foodshop.Modal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Configuration
{
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.ToTable("Voucher");
            builder.HasKey(pc => pc.id);
            builder.Property(pc => pc.voucher_name);
            builder.Property(pc => pc.voucher_code);
            builder.Property(pc => pc.voucher_start_time);
            builder.Property(pc => pc.voucher_end_time);
            builder.Property(pc => pc.voucher_style);
            builder.Property(pc => pc.voucher_reduction);
            builder.Property(pc => pc.voucher_style_reduction);
            builder.Property(pc => pc.voucher_condition);
            builder.Property(pc => pc.voucher_count_use);
            builder.Property(pc => pc.voucher_status);
            builder.Property(pc => pc.created_at);
            builder.Property(pc => pc.updated_at);
        }
    }
}
