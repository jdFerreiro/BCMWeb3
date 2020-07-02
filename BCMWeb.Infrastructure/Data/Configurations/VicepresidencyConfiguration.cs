using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class VicepresidencyConfiguration : IEntityTypeConfiguration<VicePresidency>
    {
        public void Configure(EntityTypeBuilder<VicePresidency> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.VicepresidencyId });

            builder.ToTable("tblVicepresidencia");

            builder.HasIndex(e => e.CountryId)
                .HasName("IX_FK_tblVicepresidencia_tblPais");

            builder.Property(e => e.VicepresidencyId)
                .HasColumnName("IdVicepresidencia")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.AvenueStreetName)
                .HasColumnName("CalleAvenida")
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.BuildingHouseName)
                .HasColumnName("EdificioCasa")
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("Nombre");

            builder.Property(e => e.FloorLevel)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("PisoNivel");

            builder.Property(e => e.TowerSideName)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("TorreAla");

            builder.Property(e => e.UrbanizationName)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("Urbanización");

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.Vicepresidences)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresa_tblVicepresidencia_FK1");

            builder.HasOne(d => d.CountryInfo)
                .WithMany(p => p.VicePresidencies)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_tblVicepresidencia_tblPais");

            builder.HasOne(d => d.CountryStateInfo)
                .WithMany(p => p.VicePresidencies)
                .HasForeignKey(d => new { d.CountryId, d.StateId })
                .HasConstraintName("FK_tblVicepresidencia_tblEstado");

            builder.HasOne(d => d.CityInfo)
                .WithMany(p => p.VicePresidencies)
                 .HasForeignKey(d => new { d.CountryId, d.StateId, d.CityId })
                .HasConstraintName("FK_tblVicepresidencia_tblCiudad");
        }
    }
}
