using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIARTOConfiguration : IEntityTypeConfiguration<BIARTO>
    {
        public void Configure(EntityTypeBuilder<BIARTO> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocument, e.ProcessId, e.RTOId });

            builder.ToTable("tblBIARTO");

            builder.HasIndex(e => e.FrecuencyTypeId)
                .HasName("IX_FK_tblBIARTO_tblTipoFrecuencia");

            builder.HasIndex(e => new { e.CompanyId, e.ScaleId })
                .HasName("IX_FK_tblBIARTO_tblEscala");

            builder.Property(e => e.BIADocument).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.RTOId)
                .HasColumnName("IdRTO")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Comments).IsRequired();

            builder.HasOne(d => d.FrecuencyTypeInfo)
                .WithMany(p => p.BIARTOs)
                .HasForeignKey(d => d.FrecuencyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIARTO_tblTipoFrecuencia");

            builder.HasOne(d => d.ScaleInfo)
                .WithMany(p => p.BIARTOs)
                .HasForeignKey(d => new { d.CompanyId, d.ScaleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIARTO_tblEscala");

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIARTOs)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocument, d.ProcessId })
                .HasConstraintName("FK_tblBIARTO_tblBIAProceso");
        }
    }
}
