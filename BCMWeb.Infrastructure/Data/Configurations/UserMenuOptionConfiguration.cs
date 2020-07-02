using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class UserMenuOptionConfiguration : IEntityTypeConfiguration<UserMenuOption>
    {
        public void Configure(EntityTypeBuilder<UserMenuOption> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.MenuOptionId, e.UserId });

            builder.ToTable("tblModulo_Usuario");

            builder.HasIndex(e => e.UserId)
                .HasName("IX_FK_tblModulo_Usuario_tblUsuario");

            builder.HasOne(d => d.UserInfo)
                .WithMany(p => p.MenuOptions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblModulo_Usuario_tblUsuario");

            builder.HasOne(d => d.MenuOptionInfo)
                .WithMany(p => p.UserMenuOptions)
                .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId })
                .HasConstraintName("FK_tblModulo_Usuario_tblModulo");
        }
    }
}
