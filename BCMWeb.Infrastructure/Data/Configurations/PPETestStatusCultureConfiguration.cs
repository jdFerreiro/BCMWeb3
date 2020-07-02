using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestStatusCultureConfiguration : IEntityTypeConfiguration<PPETestStatusCulture>
    {
        public void Configure(EntityTypeBuilder<PPETestStatusCulture> builder)
        {
            builder.HasKey(e => new { e.Cultura, e.StatusId });

            builder.ToTable("tblCultura_PBEPruebaEstatus");

            builder.HasIndex(e => e.StatusId)
                .HasName("IX_FK_tblCultura_PBEPruebaEjecucionEstatus_tblPBEPruebaEjecucionEstatus");

            builder.Property(e => e.Cultura)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.PPETestStatusInfo)
                .WithMany(p => p.PPETestStatusCultures)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_PBEPruebaEjecucionEstatus_tblPBEPruebaEjecucionEstatus");
        }
    }
}
