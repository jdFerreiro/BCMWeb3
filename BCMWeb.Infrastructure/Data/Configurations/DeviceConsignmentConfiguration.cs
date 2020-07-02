using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DeviceConsignmentConfiguration : IEntityTypeConfiguration<DeviceConsignment>
    {
        public void Configure(EntityTypeBuilder<DeviceConsignment> builder)
        {
            builder.HasKey(e => new { e.DeviceId, e.UserOwnerId, e.CompanyId, e.SubmoduleId, e.UserConsignmentId, e.ConsignmentDate });

            builder.ToTable("tblDispositivoEnvio");

            builder.HasIndex(e => e.UserOwnerId)
                .HasName("IX_FK_tblDispositivoEnvio_tblUsuarioRecibe");

            builder.HasIndex(e => e.UserConsignmentId)
                .HasName("IX_FK_tblDispositivoEnvio_tblUsuarioEnvia");

            builder.HasIndex(e => new { e.CompanyId, e.SubmoduleId })
                .HasName("IX_FK_tblDispositivoEnvio_tblEmpresaModulo");

            builder.Property(e => e.ConsignmentDate).HasColumnType("datetime");

            builder.Property(e => e.DownloadDate).HasColumnType("datetime");

            builder.HasOne(d => d.DeviceInfo)
                .WithMany(p => p.DeviceConsignments)
                .HasForeignKey(d => d.DeviceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDispositivoEnvio_tblDispositivo");

            builder.HasOne(d => d.UserOwnerInfo)
                .WithMany(p => p.MobileDeviceReceivesByUser)
                .HasForeignKey(d => d.UserOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDispositivoEnvio_tblUsuarioRecibe");

            builder.HasOne(d => d.UserConsingmentInfo)
                .WithMany(p => p.MobileDeviceSendsByUser)
                .HasForeignKey(d => d.UserConsignmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDispositivoEnvio_tblUsuarioEnvia");

            builder.HasOne(d => d.CompanyMenuOptionInfo)
                .WithMany(p => p.DeviceConsignment)
                .HasForeignKey(d => new { d.CompanyId, d.SubmoduleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDispositivoEnvio_tblEmpresaModulo");
        }
    }
}
