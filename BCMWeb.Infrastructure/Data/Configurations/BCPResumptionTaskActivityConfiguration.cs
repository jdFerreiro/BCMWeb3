using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCPResumptionTaskActivityConfiguration : IEntityTypeConfiguration<BCPResumptionTaskActivity>
    {
        public void Configure(EntityTypeBuilder<BCPResumptionTaskActivity> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId, e.BCPResumptionTaskId, e.BCPResumptionTaskActivityId });

            builder.ToTable("tblBCPReanudacionTareaActividad");

            builder.Property(e => e.BCPDocumentId).HasColumnName("IdDocumentoBCP");

            builder.Property(e => e.BCPResumptionTaskId).HasColumnName("IdBCPReanudacionTarea");

            builder.Property(e => e.BCPResumptionTaskActivityId)
                .HasColumnName("IdBCPReanudacionTareaActividad")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Description).IsRequired();

            builder.HasOne(d => d.BCPResumptionTaskInfo)
                .WithMany(p => p.BCPResumptionTaskActivities)
                .HasForeignKey(d => new { d.CompanyId, d.BCPDocumentId, d.BCPResumptionTaskId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBCPReanudacionTarea_tblBCPReanudacionTareaActividad_FK1");
        }
    }
}
