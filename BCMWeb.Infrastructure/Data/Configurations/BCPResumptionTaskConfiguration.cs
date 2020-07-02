using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCPResumptionTaskConfiguration : IEntityTypeConfiguration<BCPResumptionTask>
    {
        public void Configure(EntityTypeBuilder<BCPResumptionTask> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId, e.BCPResumptionTaskId });

            builder.ToTable("tblBCPReanudacionTarea");

            builder.Property(e => e.BCPDocumentId).HasColumnName("IdDocumentoBCP");

            builder.Property(e => e.BCPResumptionTaskId)
                .HasColumnName("IdBCPReanudacionTarea")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.BCPDocument)
                .WithMany(p => p.BCPRestartTasks)
                .HasForeignKey(d => new { d.CompanyId, d.BCPDocumentId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBCPDocumento_tblBCPReanudacionTarea_FK1");
        }
    }
}
