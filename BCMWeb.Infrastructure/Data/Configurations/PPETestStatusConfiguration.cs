using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestStatusConfiguration : IEntityTypeConfiguration<PPETestStatus>
    {
        public void Configure(EntityTypeBuilder<PPETestStatus> builder)
        {
            builder.HasKey(e => e.StatusId);

            builder.ToTable("tblPBEPruebaEstatus");

            builder.Property(e => e.StatusId).ValueGeneratedNever();
        }
    }
}
