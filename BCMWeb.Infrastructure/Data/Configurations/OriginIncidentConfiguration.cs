using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class OriginIncidentConfiguration : IEntityTypeConfiguration<OriginIncident>
    {
        public void Configure(EntityTypeBuilder<OriginIncident> builder)
        {
            builder.HasKey(e => e.OriginIncidentId);

            builder.ToTable("tblNaturalezaIncidente");
        }
    }
}
