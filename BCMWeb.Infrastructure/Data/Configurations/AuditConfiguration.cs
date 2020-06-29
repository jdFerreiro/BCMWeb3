using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class AuditConfiguration : IEntityTypeConfiguration<Audit>
    {
        public void Configure(EntityTypeBuilder<Audit> builder)
        {
            builder.HasKey(e => e.AuditId);

            builder.ToTable("tblAuditoria");

            builder.HasIndex(e => e.CompanyId)
                .HasName("IX_FK_tblEmpresa_tblAuditoria_FK1");

            builder.HasIndex(e => e.UserId)
                .HasName("IX_FK_tblUsuario_tblAuditoria_FK1");

            builder.HasIndex(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId })
                .HasName("IX_FK_tblAuditoria_tblDocumento");

            builder.Property(e => e.Action)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.IPAddress)
                .IsRequired()
                .HasColumnName("DireccionIP")
                .HasMaxLength(250);

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.Property(e => e.Message)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.Audits)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_tblEmpresa_tblAuditoria_FK1");

            builder.HasOne(d => d.UserInfo)
                .WithMany(p => p.Audits)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblUsuario_tblAuditoria_FK1");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.Audits)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .HasConstraintName("FK_tblAuditoria_tblDocumento");
        }
    }
}
