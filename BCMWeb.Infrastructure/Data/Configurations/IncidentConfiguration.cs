using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class IncidentConfiguration : IEntityTypeConfiguration<Incident>
    {
        public void Configure(EntityTypeBuilder<Incident> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.IncidentId });

            builder.ToTable("tblIncidentes");

            builder.HasIndex(e => e.SourceIncidentId)
                .HasName("IX_FK_tblIncidentes_tblFuenteIncidente");

            builder.HasIndex(e => e.OriginIncidentId)
                .HasName("IX_FK_tblIncidentes_tblNaturalezaIncidente");

            builder.HasIndex(e => e.IncidentType)
                .HasName("IX_FK_tblIncidentes_tblTipoIncidente");

            builder.Property(e => e.IncidentId).ValueGeneratedOnAdd();

            builder.Property(e => e.IncidentDate).HasColumnType("datetime");

            builder.Property(e => e.ReporterName).HasMaxLength(500);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.Incidents)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblIncidentes_tblEmpresa");

            builder.HasOne(d => d.IncidentSourceInfo)
                .WithMany(p => p.Incidents)
                .HasForeignKey(d => d.SourceIncidentId)
                .HasConstraintName("FK_tblIncidentes_tblFuenteIncidente");

            builder.HasOne(d => d.OriginIncidentInfo)
                .WithMany(p => p.Incidents)
                .HasForeignKey(d => d.OriginIncidentId)
                .HasConstraintName("FK_tblIncidentes_tblNaturalezaIncidente");

            builder.HasOne(d => d.IncidentTypeInfo)
                .WithMany(p => p.Incidents)
                .HasForeignKey(d => d.IncidentType)
                .HasConstraintName("FK_tblIncidentes_tblTipoIncidente");
        }
    }
}
