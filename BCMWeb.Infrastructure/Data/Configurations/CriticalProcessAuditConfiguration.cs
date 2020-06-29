using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CriticalProcessAuditConfiguration : IEntityTypeConfiguration<CriticalProcessAudit>
    {
        public void Configure(EntityTypeBuilder<CriticalProcessAudit> builder)
        {
            builder.HasKey(e => new { e.ProcessId, e.CriticalProcessAuditId });

            builder.ToTable("tblAuditoriaProcesoCritico");

            builder.HasIndex(e => e.CompanyId)
                .HasName("IX_FK_tblAuditoriaProcesoCritico_tblEmpresa");

            builder.Property(e => e.CriticalProcessAuditId).ValueGeneratedOnAdd();

            builder.Property(e => e.LastUpdate).HasColumnType("datetime");

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.CriticalProcessAudit)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAuditoriaProcesoCritico_tblEmpresa");

            builder.HasOne(d => d.UserInfo)
                .WithMany(p => p.CriticalProcessAudit)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAuditoriaProcesoCritico_tblUsuario");
        }
    }
}
