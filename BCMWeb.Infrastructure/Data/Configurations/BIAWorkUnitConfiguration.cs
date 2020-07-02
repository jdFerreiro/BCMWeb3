using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAWorkUnitConfiguration : IEntityTypeConfiguration<BIAWorkUnit>
    {
        public void Configure(EntityTypeBuilder<BIAWorkUnit> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.WorkUnitId });

            builder.ToTable("tblBIAUnidadTrabajo");

            builder.HasIndex(e => new { e.CompanyId, e.OUId })
                .HasName("IX_FK_tblBIAUnidadTrabajo_tblUnidadOrganizativa");

            builder.Property(e => e.WorkUnitId).ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.BIAWorkUnits)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAUnidadTrabajo_tblEmpresa");

            builder.HasOne(d => d.OUInfo)
                .WithMany(p => p.BIAWorkUnits)
                .HasForeignKey(d => new { d.CompanyId, d.OUId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAUnidadTrabajo_tblUnidadOrganizativa");
        }
    }
}
