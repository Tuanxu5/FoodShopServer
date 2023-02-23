using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using foodshop.Modal;

namespace foodshop.Configuration
{
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(pc => pc.id);
            builder.Property(pc => pc.users_name);
            builder.Property(pc => pc.users_password);
            builder.Property(pc => pc.users_lastname);
            builder.Property(pc => pc.users_firstname);
            builder.Property(pc => pc.users_province);
            builder.Property(pc => pc.users_district);
            builder.Property(pc => pc.users_specific_address);
            builder.Property(pc => pc.users_number_phone);
            builder.Property(pc => pc.created_at);
            builder.Property(pc => pc.updated_at);
        }
    }
}
