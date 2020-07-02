using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class RiskProbabilityConfiguration : IEntityTypeConfiguration<RiskProbability>
    {
        public void Configure(EntityTypeBuilder<RiskProbability> builder)
        {
            builder.HasKey(e => new { e.ComanyId, e.ProbabilityId });

            builder.ToTable("tblProbabilidadRiesgo");

            builder.Property(e => e.GraphicLabel).HasMaxLength(250);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.RiskProbabilities)
                .HasForeignKey(d => d.ComanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAProbabilidadRiesgo_tblEmpresa");
        }
    }
}
