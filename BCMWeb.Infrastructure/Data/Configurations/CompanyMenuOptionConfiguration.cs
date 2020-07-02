using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CompanyMenuOptionConfiguration : IEntityTypeConfiguration<CompanyMenuOption>
    {
        public void Configure(EntityTypeBuilder<CompanyMenuOption> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.MenuOptionId });

            builder.ToTable("tblEmpresaModulo");

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.CompanyMenuOptions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresaModulo_tblEmpresa");

            builder.HasOne(d => d.MenuOpcionInfo)
                .WithOne(p => p.CompanyMenuOption)
                .HasForeignKey<CompanyMenuOption>(d => new { d.CompanyId, d.MenuOptionId })
                .HasConstraintName("FK_tblEmpresaModulo_tblModulo");
        }
    }
}
