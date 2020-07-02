using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PMTScheduleNotificationTypeCultureConfiguration : IEntityTypeConfiguration<PMTScheduleNotificationTypeCulture>
    {
        public void Configure(EntityTypeBuilder<PMTScheduleNotificationTypeCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.NotificationTypeId });

            builder.ToTable("tblCultura_PMTProgramacionTipoNotificacion");

            builder.HasIndex(e => e.NotificationTypeId)
                .HasName("IX_FK_tblCultura_PMTProgramacionTipoNotificacion_tblPMTProgramacionTipoNotificacion");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(d => d.NotificationTypeInfo)
                .WithMany(p => p.PMTScheduleNotificationTypeCultures)
                .HasForeignKey(d => d.NotificationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_PMTProgramacionTipoNotificacion_tblPMTProgramacionTipoNotificacion");
        }
    }
}
