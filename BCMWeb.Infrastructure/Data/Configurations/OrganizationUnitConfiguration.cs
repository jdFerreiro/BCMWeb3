using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class OrganizationUnitConfiguration : IEntityTypeConfiguration<OrganizationUnit>
    {
        public void Configure(EntityTypeBuilder<OrganizationUnit> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.OrganizationUnitId });

            builder.ToTable("tblUnidadOrganizativa");

            builder.Property(e => e.CompanyId)
                .HasColumnName("IdEmpresa");

            builder.Property(e => e.OrganizationUnitId)
                .HasColumnName("IdUnidadOrganizativa")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .HasColumnName("Nombre")
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.ParentId)
                .HasColumnName("IdUnidadPadre")
                .ValueGeneratedOnAdd();

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.UOs)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresa_tblUnidadOrganizativa_FK1");

        }
    }
}
