using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class MenuOptionConfiguration : IEntityTypeConfiguration<MenuOption>
    {
        public void Configure(EntityTypeBuilder<MenuOption> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.MenuOptionId });

            builder.ToTable("tblModulo");

            builder.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Controller)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Description).HasMaxLength(4000);

            builder.Property(e => e.ImageRoot)
                .HasColumnName("imageRoot")
                .HasMaxLength(500);

            builder.Property(e => e.Name).HasMaxLength(250);

            builder.Property(e => e.Title).HasMaxLength(450);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.MenuOptions)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_tblModulo_tblEmpresa");
        }
    }
}
