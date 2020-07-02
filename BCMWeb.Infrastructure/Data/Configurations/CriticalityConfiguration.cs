using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CriticalityConfiguration : IEntityTypeConfiguration<Criticality>
    {
        public void Configure(EntityTypeBuilder<Criticality> builder)
        {
            builder.HasKey(e => new { e.ApplicationDate, e.CompanyId, e.EscaleTypeId });

            builder.ToTable("tblCriticidad");

            builder.HasIndex(e => e.CompanyId)
                .HasName("IX_FK_tblCriticidad_tblEmpresa");

            builder.HasIndex(e => new { e.CompanyId, e.EscaleTypeId })
                .HasName("IX_FK_tblCriticidad_tblTipoEscala");

            builder.Property(e => e.ApplicationDate).HasColumnType("datetime");

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.Criticalitys)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCriticidad_tblEmpresa");

            builder.HasOne(d => d.ScaleInfo)
                .WithMany(p => p.Citricities)
                .HasForeignKey(d => new { d.CompanyId, d.EscaleTypeId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCriticidad_tblTipoEscala");
        }
    }
}
