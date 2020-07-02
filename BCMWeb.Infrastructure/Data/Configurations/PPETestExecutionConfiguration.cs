using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestExecutionConfiguration : IEntityTypeConfiguration<PPETestExecution>
    {
        public void Configure(EntityTypeBuilder<PPETestExecution> builder)
        {
            builder.HasKey(e => new { e.CountryId, e.ScheduleId });

            builder.ToTable("tblPBEPruebaEjecucion");

            builder.Property(e => e.StartDate).HasColumnType("datetime");

            builder.Property(e => e.LocationName)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.PPETestExecutions)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaEjecucion_tblEmpresa");

            builder.HasOne(d => d.PPETestScheduleInfo)
                .WithOne(p => p.PPETestExecutionInfo)
                .HasForeignKey<PPETestExecution>(d => new { d.CountryId, d.ScheduleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaEjecucion_tblPBEPruebaPlanificacion");
        }
    }
}
