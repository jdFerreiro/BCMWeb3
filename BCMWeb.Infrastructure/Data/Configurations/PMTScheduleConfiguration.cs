using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PMTScheduleConfiguration : IEntityTypeConfiguration<PMTSchedule>
    {
        public void Configure(EntityTypeBuilder<PMTSchedule> builder)
        {
            builder.HasKey(e => e.PMTScheduleId);

            builder.ToTable("tblPMTProgramacion");

            builder.HasIndex(e => e.CompanyId)
                .HasName("IX_FK_tblPMTProgramacion_tblEmpresa");

            builder.HasIndex(e => e.UpdateTypeId)
                .HasName("IX_FK_tblPMTProgramacion_tblPMTProgramacionTipoActualizacion");

            builder.HasIndex(e => e.FrecuencyTypeId)
                .HasName("IX_FK_tblPMTProgramacion_tblTipoFrecuencia");

            builder.HasIndex(e => new { e.CompanyId, e.MenuOptionId })
                .HasName("IX_FK_tblPMTProgramacion_tblModulo");

            builder.Property(e => e.PMTScheduleId).HasColumnName("IdPMTProgramacion");

            builder.Property(e => e.EndDate).HasColumnType("datetime");

            builder.Property(e => e.StartDate).HasColumnType("datetime");

            builder.HasOne(d => d.CompanyIdInfo)
                .WithMany(p => p.PMTSchedules)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTProgramacion_tblEmpresa");

            builder.HasOne(d => d.UpdateTypeInfo)
                .WithMany(p => p.PMTSchedules)
                .HasForeignKey(d => d.UpdateTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTProgramacion_tblPMTProgramacionTipoActualizacion");

            builder.HasOne(d => d.FrecuencyTypeInfo)
                .WithMany(p => p.PMTSchedules)
                .HasForeignKey(d => d.FrecuencyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTProgramacion_tblTipoFrecuencia");

            builder.HasOne(d => d.MenuOptionInfo)
                .WithMany(p => p.PMTSchedules)
                .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTProgramacion_tblModulo");
        }
    }
}
