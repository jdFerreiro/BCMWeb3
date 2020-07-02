using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAProcessConfiguration : IEntityTypeConfiguration<BIAProcess>
    {
        public void Configure(EntityTypeBuilder<BIAProcess> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId });

            builder.ToTable("tblBIAProceso");

            builder.HasIndex(e => e.ProcessStateId)
                .HasName("IX_FK_tblBIAProceso_tblEstadoProceso");

            builder.HasIndex(e => new { e.CompanyId, e.OUId })
                .HasName("IX_FK_tblBIAProceso_tblUnidadOrganizativa");

            builder.Property(e => e.ProcessId).ValueGeneratedOnAdd();

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.Property(e => e.LastProcessStateDate).HasColumnType("datetime");

            builder.Property(e => e.Name).HasMaxLength(1500);

            builder.HasOne(d => d.ProcessStateInfo)
                .WithMany(p => p.BIAProcesses)
                .HasForeignKey(d => d.ProcessStateId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblBIAProceso_tblEstadoProceso");

            builder.HasOne(d => d.BIADocumentInfo)
                .WithMany(p => p.BIAProcesses)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId })
                .HasConstraintName("FK_tblBIAProceso_tblBIADocumento");

            builder.HasOne(d => d.OUInfo)
                .WithMany(p => p.BIAProcesses)
                .HasForeignKey(d => new { d.CompanyId, d.OUId })
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblBIAProceso_tblUnidadOrganizativa");
        }
    }
}
