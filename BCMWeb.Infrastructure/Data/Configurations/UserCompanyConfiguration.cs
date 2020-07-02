using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class UserCompanyConfiguration : IEntityTypeConfiguration<UserCompany>
    {
        public void Configure(EntityTypeBuilder<UserCompany> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.UserId });

            builder.ToTable("tblEmpresaUsuario");

            builder.HasIndex(e => e.LevelUserId)
                .HasName("IX_FK_tblEmpresaUsuario_tblNivelUsuario");

            builder.HasIndex(e => e.UserId)
                .HasName("IX_FK_tblEmpresaUsuario_tblUsuario");

            builder.Property(e => e.CreationDate).HasColumnType("datetime");

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.CompanyUsers)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresaUsuario_tblEmpresa");

            builder.HasOne(d => d.UserLevelInfo)
                .WithMany(p => p.UserCompanys)
                .HasForeignKey(d => d.LevelUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresaUsuario_tblNivelUsuario");

            builder.HasOne(d => d.UserInfo)
                .WithMany(p => p.Companies)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresaUsuario_tblUsuario");
        }
    }
}
