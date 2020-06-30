using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(e => e.CompanyId);

            builder.ToTable("tblEmpresa");

            builder.HasIndex(e => e.CompanyStateId)
                .HasName("IX_FK_tblEmpresa_tblEstadoEmpresa");

            builder.HasIndex(e => e.CountryId)
                .HasName("IX_FK_tblEmpresa_tblPais");

            builder.HasIndex(e => new { e.CountryId, e.StateId })
                .HasName("IX_FK_tblEmpresa_tblEstado");

            builder.HasIndex(e => new { e.CountryId, e.StateId, e.CityId })
                .HasName("IX_FK_tblEmpresa_tblCiudad");

            builder.Property(e => e.CompanyId)
                .HasColumnName("IdEmpresa");
            builder.Property(e => e.AdministrativeAddress)
                .HasColumnName("DireccionAdministrativa")
                .IsRequired();
            builder.Property(e => e.StartDate)
                .HasColumnName("FechaInicioActividad")
                .HasColumnType("datetime");
            builder.Property(e => e.CompanyStateLastUpdate)
                .HasColumnName("FechaUltimoEstado")
                .HasColumnType("datetime");
            builder.Property(e => e.LogoUrl)
                .IsRequired()
                .HasColumnName("LogoURL")
                .HasMaxLength(250);
            builder.Property(e => e.Tradename)
                .IsRequired()
                .HasColumnName("NombreComercial")
                .HasMaxLength(250);
            builder.Property(e => e.LegalName)
                .IsRequired()
                .HasColumnName("NombreFiscal")
                .HasMaxLength(250);
            builder.Property(e => e.GovermentId)
                .IsRequired()
                .HasColumnName("RegistroFiscal")
                .HasMaxLength(50);
            builder.Property(e => e.CompanyStateId)
                .IsRequired()
                .HasColumnName("IdEstado");
            builder.Property(e => e.CanCreateApps)
                .HasColumnName("CrearAplicaciones")
                .HasColumnType("boolean");
            builder.Property(e => e.CanCreateDocs)
                .HasColumnName("CrearDocumento")
                .HasColumnType("boolean");
            builder.Property(e => e.CanCreateProcess)
                .HasColumnName("CrearProcesos")
                .HasColumnType("boolean");
            builder.Property(e => e.CanCreateUO)
                .HasColumnName("CrearUnidadOrganizativa")
                .HasColumnType("boolean");
            builder.Property(e => e.CanCreateWorkUnit)
                .HasColumnName("CrearUnidadTrabajo")
                .HasColumnType("boolean");
            builder.Property(e => e.CountryId)
                .HasColumnName("IdPais");
            builder.Property(e => e.StateId)
                .HasColumnName("IdPaisEstado");
            builder.Property(e => e.CityId)
                .HasColumnName("IdPaisEstadoCiudad");



            builder.HasOne(d => d.CompanyStateInfo)
                .WithMany(p => p.Companies)
                .HasForeignKey(d => d.CompanyStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresa_tblEstadoEmpresa");

            builder.HasOne(d => d.CountryInfo)
                .WithMany(p => p.Companies)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_tblEmpresa_tblPais");

            builder.HasOne(d => d.StateInfo)
                .WithMany(p => p.Companies)
                .HasForeignKey(d => new { d.CountryId, d.StateId })
                .HasConstraintName("FK_tblEmpresa_tblEstado");

            builder.HasOne(d => d.CityInfo)
                .WithMany(p => p.Companies)
                .HasForeignKey(d => new { d.CountryId, d.StateId, d.CityId })
                .HasConstraintName("FK_tblEmpresa_tblCiudad");
        }
    }
}
