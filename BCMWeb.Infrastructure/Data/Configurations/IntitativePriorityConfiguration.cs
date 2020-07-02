using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class IntitativePriorityConfiguration : IEntityTypeConfiguration<IntitativePriority>
    {
        public void Configure(EntityTypeBuilder<IntitativePriority> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.PriorityId });

            builder.ToTable("tblIniciativaPrioridad");

            builder.Property(e => e.Name).HasMaxLength(50);
        }
    }
}
