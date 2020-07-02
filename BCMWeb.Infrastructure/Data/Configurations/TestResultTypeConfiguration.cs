using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class TestResultTypeConfiguration : IEntityTypeConfiguration<TestResultType>
    {
        public void Configure(EntityTypeBuilder<TestResultType> builder)
        {
            builder.HasKey(e => e.TestResultTypeId);

            builder.ToTable("tblTipoResultadoPrueba");

            builder.Property(e => e.TestResultTypeId).ValueGeneratedNever();
        }
    }
}
