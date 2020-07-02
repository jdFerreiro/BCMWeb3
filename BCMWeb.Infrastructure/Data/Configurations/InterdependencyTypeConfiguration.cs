using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class InterdependencyTypeConfiguration : IEntityTypeConfiguration<InterdependencyType>
    {
        public void Configure(EntityTypeBuilder<InterdependencyType> builder)
        {
            builder.HasKey(e => e.InterdependencyTypeId);

            builder.ToTable("tblTipoInterdependencia");

            builder.Property(e => e.InterdependencyTypeId).ValueGeneratedNever();
        }
    }
}
