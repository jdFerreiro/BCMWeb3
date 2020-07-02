using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIARPOConfiguration : IEntityTypeConfiguration<BIARPO>
    {
        public void Configure(EntityTypeBuilder<BIARPO> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.RPOId });

            builder.ToTable("tblBIARPO");

            builder.HasIndex(e => e.FrecuencyTypeId)
                .HasName("IX_FK_tblBIARPO_tblTipoFrecuencia");

            builder.HasIndex(e => new { e.CompanyId, e.ScaleId })
                .HasName("IX_FK_tblBIARPO_tblEscala");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.RPOId)
                .HasColumnName("IdRPO")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Comments)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.FrecuencyTypeInfo)
                .WithMany(p => p.BIARPOs)
                .HasForeignKey(d => d.FrecuencyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIARPO_tblTipoFrecuencia");

            builder.HasOne(d => d.ScaleInfo)
                .WithMany(p => p.BIARPOs)
                .HasForeignKey(d => new { d.CompanyId, d.ScaleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIARPO_tblEscala");

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIARPOs)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIARPO_tblBIAProceso");
        }
    }
}
