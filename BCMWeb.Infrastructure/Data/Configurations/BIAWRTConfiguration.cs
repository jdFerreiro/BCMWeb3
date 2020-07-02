using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAWRTConfiguration : IEntityTypeConfiguration<BIAWRT>
    {
        public void Configure(EntityTypeBuilder<BIAWRT> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.WRTId });

            builder.ToTable("tblBIAWRT");

            builder.HasIndex(e => e.FrecuencyTypeId)
                .HasName("IX_FK_tblBIAWRT_tblTipoFrecuencia");

            builder.HasIndex(e => new { e.CompanyId, e.ScaleId })
                .HasName("IX_FK_tblBIAWRT_tblEscala");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.WRTId)
                .HasColumnName("IdWRT")
                .ValueGeneratedOnAdd();

            builder.HasOne(d => d.FrecuencyTypeInfo)
                .WithMany(p => p.BIAWRTs)
                .HasForeignKey(d => d.FrecuencyTypeId)
                .HasConstraintName("FK_tblBIAWRT_tblTipoFrecuencia");

            builder.HasOne(d => d.ScaleInfo)
                .WithMany(p => p.BIAWRTs)
                .HasForeignKey(d => new { d.CompanyId, d.ScaleId })
                .HasConstraintName("FK_tblBIAWRT_tblEscala");

            builder.HasOne(d => d.BiaProcessInfo)
                .WithMany(p => p.BIAWRT)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAWRT_tblBIAProceso");
        }
    }
}
