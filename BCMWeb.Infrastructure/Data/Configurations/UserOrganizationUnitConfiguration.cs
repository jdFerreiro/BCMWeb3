using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class UserOrganizationUnitConfiguration : IEntityTypeConfiguration<UserOrganizationUnit>
    {
        public void Configure(EntityTypeBuilder<UserOrganizationUnit> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.OrganizationUnitId, e.UserId });

            builder.ToTable("tblUsuarioUnidadOrganizativa");

            builder.HasIndex(e => e.LevelUserId)
                .HasName("IX_FK_tblUsuarioUnidadOrganizativa_tblNivelUsuario");

            builder.HasIndex(e => e.UserId)
                .HasName("IX_FK_tblUsuarioUnidadOrganizativa_tblUsuario");

            builder.Property(e => e.CompanyId)
                .HasColumnName("IdEmpresa")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.OrganizationUnitId)
                .HasColumnName("IdUnidadOrganizativa")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UserId)
                .HasColumnName("IdUsuario")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.LevelUserId)
                .HasColumnName("IdNivelUsuario")
                .ValueGeneratedOnAdd();

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.UserUOs)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblEmpresa");

            builder.HasOne(d => d.UserLevelInfo)
                .WithMany(p => p.UserOUs)
                .HasForeignKey(d => d.LevelUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblNivelUsuario");

            builder.HasOne(d => d.UserInfo)
                .WithMany(p => p.OrganizationUnits)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblUsuario");

            builder.HasOne(d => d.OrganizationUnitInfo)
                .WithMany(p => p.UserOUs)
                .HasForeignKey(d => new { d.CompanyId, d.OrganizationUnitId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblUnidadOrganizativa");
        }
    }
}
