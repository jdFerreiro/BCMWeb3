using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CultureLevelUserConfiguration : IEntityTypeConfiguration<CultureLevelUser>
    {
        public void Configure(EntityTypeBuilder<CultureLevelUser> builder)
        {
            builder.HasKey(e => new { e.Culture, e.LevelUserId });

            builder.ToTable("tblCultura_NivelUsuario");

            builder.HasIndex(e => e.LevelUserId)
                .HasName("IX_FK_tblCulture_NivelUsuario_tblNivelUsuario");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(450);

            builder.HasOne(d => d.LevelUserInfo)
                .WithMany(p => p.UserLevelCultures)
                .HasForeignKey(d => d.LevelUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCulture_NivelUsuario_tblNivelUsuario");
        }
    }
}
