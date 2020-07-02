using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestExecutionResultConfiguration : IEntityTypeConfiguration<PPETestExecutionResult>
    {
        public void Configure(EntityTypeBuilder<PPETestExecutionResult> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ContentId });

            builder.ToTable("tblPBEPruebaEjecucionResultado");

            builder.Property(e => e.Content).IsRequired();

            builder.HasOne(d => d.PPETestExecutionInfo)
                .WithMany(p => p.PPETestExecutionResult)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaEjecucionResultado_tblPBEPruebaEjecucion");
        }
    }
}
