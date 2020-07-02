using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class ResultTypeConfiguration : IEntityTypeConfiguration<ResultType>
    {
        public void Configure(EntityTypeBuilder<ResultType> builder)
        {
            builder.HasKey(e => e.ResultTypeId);

            builder.ToTable("tblTipoRespaldo");

            builder.Property(e => e.ResultTypeId).ValueGeneratedNever();
        }
    }
}
