using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class UserLevelConfiguration : IEntityTypeConfiguration<UserLevel>
    {
        public void Configure(EntityTypeBuilder<UserLevel> builder)
        {
            builder.HasKey(e => e.LevelUserId);

            builder.ToTable("tblNivelUsuario");

            builder.Property(e => e.LevelUserId).ValueGeneratedNever();

            builder.Property(e => e.UserRole)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
