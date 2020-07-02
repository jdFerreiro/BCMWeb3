using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class MenuAttachConfiguration : IEntityTypeConfiguration<MenuAttach>
    {
        public void Configure(EntityTypeBuilder<MenuAttach> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.MenuOptionId, e.ForBussiness, e.AttachId });

            builder.ToTable("tblModuloAnexo");

            builder.Property(e => e.AttachId).ValueGeneratedOnAdd();

            builder.Property(e => e.LastWriteTime).HasColumnType("datetime");

            builder.Property(e => e.Name).HasMaxLength(500);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.ModuleAttachments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblModuloAnexo_tblEmpresa");
        }
    }
}
