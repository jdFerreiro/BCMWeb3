using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAWorkUnitProcessConfiguration : IEntityTypeConfiguration<BIAWorkUnitProcess>
    {
        public void Configure(EntityTypeBuilder<BIAWorkUnitProcess> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.WorkUnitId, e.WorkUnitProcessId });

            builder.ToTable("tblBIAUnidadTrabajoProceso");

            builder.HasIndex(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId })
                .HasName("IX_FK_tblBIAUnidadTrabajoProceso_tblBIAProceso");

            builder.Property(e => e.WorkUnitProcessId).ValueGeneratedOnAdd();

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.BIAWorkUnitInfo)
                .WithMany(p => p.WorkUnitProcesses)
                .HasForeignKey(d => new { d.CompanyId, d.WorkUnitId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAUnidadTrabajoProceso_tblBIAUnidadTrabajo");

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAWorkUnitProcesses)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAUnidadTrabajoProceso_tblBIAProceso");
        }
    }
}
