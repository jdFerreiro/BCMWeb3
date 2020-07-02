using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.HasKey(e => e.DeviceId);

            builder.ToTable("tblDispositivo");

            builder.HasIndex(e => e.UserOwnerId)
                .HasName("IX_FK_tblDispositivo_tblUsuario");

            builder.Property(e => e.MakerName).HasMaxLength(500);

            builder.Property(e => e.CreateDate).HasColumnType("datetime");

            builder.Property(e => e.IMEI)
                .HasColumnName("IMEI_Dispositivo")
                .HasMaxLength(100);

            builder.Property(e => e.Model).HasMaxLength(500);

            builder.Property(e => e.Name).HasMaxLength(500);

            builder.Property(e => e.Platform).HasMaxLength(500);

            builder.Property(e => e.DeviceType).HasMaxLength(500);

            builder.Property(e => e.Version).HasMaxLength(500);

            builder.HasOne(d => d.UserInfo)
                .WithMany(p => p.MobileDevices)
                .HasForeignKey(d => d.UserOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDispositivo_tblUsuario");
        }
    }
}
