using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PMTScheduleUserConfiguration : IEntityTypeConfiguration<PMTScheduleUser>
    {
        public void Configure(EntityTypeBuilder<PMTScheduleUser> builder)
        {
            builder.HasKey(e => new { e.PMTScheduleId, e.UserId });

            builder.ToTable("tblPMTProgramacionUsuario");

            builder.HasIndex(e => e.NotifyTypeId)
                .HasName("IX_FK_tblPMTProgramacionUsuario_tblPMTProgramacionTipoNotificacion");

            builder.HasIndex(e => e.UserId)
                .HasName("IX_FK_tblPMTProgramacionUsuario_tblUsuario");

            builder.Property(e => e.PMTScheduleId).HasColumnName("IdPMTProgramacion");

            builder.Property(e => e.LastUpdateDate).HasColumnType("datetime");

            builder.HasOne(d => d.PMTScheduleInfo)
                .WithMany(p => p.PMTScheduleUsers)
                .HasForeignKey(d => d.PMTScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTProgramacionUsuario_tblPMTProgramacion");

            builder.HasOne(d => d.PMTScheduleNotifyTypeInfo)
                .WithMany(p => p.PMTScheduleUsers)
                .HasForeignKey(d => d.NotifyTypeId)
                .HasConstraintName("FK_tblPMTProgramacionUsuario_tblPMTProgramacionTipoNotificacion");

            builder.HasOne(d => d.UserInfo)
                .WithMany(p => p.MaintenancePlanSchedules)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTProgramacionUsuario_tblUsuario");
        }
    }
}
