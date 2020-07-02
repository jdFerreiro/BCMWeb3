using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PMTScheduleNotificationTypeConfiguration : IEntityTypeConfiguration<PMTScheduleNotificationType>
    {
        public void Configure(EntityTypeBuilder<PMTScheduleNotificationType> builder)
        {
            builder.HasKey(e => e.NotificationTypeId);

            builder.ToTable("tblPMTProgramacionTipoNotificacion");

            builder.Property(e => e.NotificationTypeId).ValueGeneratedNever();
        }
    }
}
