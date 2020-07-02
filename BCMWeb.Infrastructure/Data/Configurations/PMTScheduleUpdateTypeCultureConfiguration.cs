using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PMTScheduleUpdateTypeCultureConfiguration : IEntityTypeConfiguration<PMTScheduleUpdateTypeCulture>
    {
        public void Configure(EntityTypeBuilder<PMTScheduleUpdateTypeCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.UpdateTypeId });

            builder.ToTable("tblCultura_PMTProgramacionTipoActualizacion");

            builder.HasIndex(e => e.UpdateTypeId)
                .HasName("IX_FK_tblCultura_PMTProgramacionTipoActualizacion_tblPMTProgramacionTipoActualizacion");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.PMTScheduleUpdateTypeInfo)
                .WithMany(p => p.PMTScheduleUpdateTypeCultures)
                .HasForeignKey(d => d.UpdateTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_PMTProgramacionTipoActualizacion_tblPMTProgramacionTipoActualizacion");
        }
    }
}
