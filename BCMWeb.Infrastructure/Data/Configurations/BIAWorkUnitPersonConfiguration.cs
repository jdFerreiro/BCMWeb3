using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAWorkUnitPersonConfiguration : IEntityTypeConfiguration<BIAWorkUnitPerson>
    {
        public void Configure(EntityTypeBuilder<BIAWorkUnitPerson> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.WorkUnitId, e.WorkUnitProcessId, e.PersonUnitId, e.ProcessClientId });

            builder.ToTable("tblBIAUnidadTrabajoPersonas");

            builder.HasIndex(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.ProcessClientId })
                .HasName("IX_FK_tblBIAUnidadTrabajoPersonas_tblBIAClienteProceso");

            builder.Property(e => e.PersonUnitId).ValueGeneratedOnAdd();

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.BIAWorkUnitProcessInfo)
                .WithMany(p => p.BIAWorkUnitPersons)
                .HasForeignKey(d => new { d.CompanyId, d.WorkUnitId, d.WorkUnitProcessId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAUnidadTrabajoPersonas_tblBIAUnidadTrabajoProceso");

            builder.HasOne(d => d.BIACLientProcessInfo)
                .WithMany(p => p.BIAWorkUnitPerson)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId, d.ProcessClientId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAUnidadTrabajoPersonas_tblBIAClienteProceso");
        }
    }
}
