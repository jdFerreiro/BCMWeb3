using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DeviceConnectionConfiguration : IEntityTypeConfiguration<DeviceConnection>
    {
        public void Configure(EntityTypeBuilder<DeviceConnection> builder)
        {
            builder.HasKey(e => new { e.DeviceId, e.UserOwnerId, e.ConnectionDate });

            builder.ToTable("tblDispositivoConexion");

            builder.HasIndex(e => e.CompanyId)
                .HasName("IX_FK_tblDispositivoConexion_tblEmpresa1");

            builder.Property(e => e.ConnectionDate).HasColumnType("datetime");

            builder.Property(e => e.IPAddress)
                .HasColumnName("DirecciónIP")
                .HasMaxLength(50);

            builder.HasOne(d => d.DeviceInfo)
                .WithMany(p => p.DeviceConnections)
                .HasForeignKey(d => d.DeviceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDispositivoConexion_tblDispositivo");

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.DeviceConnections)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_tblDispositivoConexion_tblEmpresa");
        }
    }
}
