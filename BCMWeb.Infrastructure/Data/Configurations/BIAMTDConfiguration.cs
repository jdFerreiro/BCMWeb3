using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAMTDConfiguration : IEntityTypeConfiguration<BIAMTD>
    {
        public void Configure(EntityTypeBuilder<BIAMTD> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.MTDId });

            builder.ToTable("tblBIAMTD");

            builder.HasIndex(e => e.FrecuencyTypeId)
                .HasName("IX_FK_tblBIAMTD_tblTipoFrecuencia");

            builder.HasIndex(e => new { e.CompanyId, e.ScaleId })
                .HasName("IX_FK_tblBIAMTD_tblEscala");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.MTDId)
                .HasColumnName("IdMTD")
                .ValueGeneratedOnAdd();

            builder.HasOne(d => d.FrecuencyTypeInfo)
                .WithMany(p => p.BIAMTDs)
                .HasForeignKey(d => d.FrecuencyTypeId)
                .HasConstraintName("FK_tblBIAMTD_tblTipoFrecuencia");

            builder.HasOne(d => d.ScaleInfo)
                .WithMany(p => p.BIAMTDs)
                .HasForeignKey(d => new { d.CompanyId, d.ScaleId })
                .HasConstraintName("FK_tblBIAMTD_tblEscala");

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAMTDs)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAMTD_tblBIAProceso");
        }
    }
}
