using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using foodshop.Modal;

namespace foodshop.Configuration
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("Store");
            builder.HasKey(pc => pc.id);
            builder.Property(pc => pc.store_name);
            builder.Property(pc => pc.store_banner);
            builder.Property(pc => pc.store_vote);
            builder.Property(pc => pc.store_province);
            builder.Property(pc => pc.store_district);
            builder.Property(pc => pc.store_specific_address);
            builder.Property(pc => pc.store_username);
            builder.Property(pc => pc.storepassword);
            builder.Property(pc => pc.categories_id);
            builder.Property(pc => pc.store_opening_time);
            builder.Property(pc => pc.store_closing_time);
            builder.Property(pc => pc.store_owner);
            builder.Property(pc => pc.store_number_phone);
            builder.Property(pc => pc.store_business_license);
            builder.Property(pc => pc.created_at);
            builder.Property(pc => pc.updated_at);
        }
    }
}
