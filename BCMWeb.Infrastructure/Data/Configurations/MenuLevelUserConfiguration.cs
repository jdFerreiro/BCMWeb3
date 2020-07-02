using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class MenuLevelUserConfiguration : IEntityTypeConfiguration<MenuLevelUser>
    {
        public void Configure(EntityTypeBuilder<MenuLevelUser> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.UserLevelId, e.MenuItemId });

            builder.ToTable("tblModulo_NivelUsuario");

            builder.HasIndex(e => e.UserLevelId)
                .HasName("IX_FK_tblModulo_NivelUsuario_tblNivelUsuario");

            builder.HasIndex(e => new { e.CompanyId, e.MenuItemId })
                .HasName("IX_FK_tblModulo_NivelUsuario_tblModulo");

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.UserLevelMenuOptions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblModulo_NivelUsuario_tblEmpresa");

            builder.HasOne(d => d.UserLevelInfo)
                .WithMany(p => p.UserLevelMenuOptions)
                .HasForeignKey(d => d.UserLevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblModulo_NivelUsuario_tblNivelUsuario");

            builder.HasOne(d => d.MenuOptionInfo)
                .WithMany(p => p.UserMenuLevels)
                .HasForeignKey(d => new { d.CompanyId, d.MenuItemId })
                .HasConstraintName("FK_tblModulo_NivelUsuario_tblModulo");
        }
    }
}
