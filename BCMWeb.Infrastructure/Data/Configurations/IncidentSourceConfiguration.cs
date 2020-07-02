using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class IncidentSourceConfiguration : IEntityTypeConfiguration<IncidentSource>
    {
        public void Configure(EntityTypeBuilder<IncidentSource> builder)
        {
            builder.HasKey(e => e.IncidentSourceId);

            builder.ToTable("tblFuenteIncidente");
        }
    }
}
