using foodshop.Modal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace foodshop.Configuration
{
    public class IncludedConfiguration : IEntityTypeConfiguration<Included>
    {
        public void Configure(EntityTypeBuilder<Included> builder)
        {
            builder.ToTable("Included");
            builder.HasKey(pc => pc.id);
            builder.Property(pc => pc.product_id);
            builder.Property(pc => pc.included_price);
            builder.Property(pc => pc.included_name);
            builder.Property(pc => pc.created_at);
            builder.Property(pc => pc.updated_at);
        }
    }
}
