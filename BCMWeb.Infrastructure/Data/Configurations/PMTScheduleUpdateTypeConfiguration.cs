using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PMTScheduleUpdateTypeConfiguration : IEntityTypeConfiguration<PMTScheduleUpdateType>
    {
        public void Configure(EntityTypeBuilder<PMTScheduleUpdateType> builder)
        {
            builder.HasKey(e => e.UpdateTypeId);

            builder.ToTable("tblPMTProgramacionTipoActualizacion");

            builder.Property(e => e.UpdateTypeId).ValueGeneratedNever();
        }
    }
}
