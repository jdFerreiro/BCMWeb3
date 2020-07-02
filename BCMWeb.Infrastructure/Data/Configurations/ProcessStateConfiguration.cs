using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class ProcessStateConfiguration : IEntityTypeConfiguration<ProcessState>
    {
        public void Configure(EntityTypeBuilder<ProcessState> builder)
        {
            builder.HasKey(e => e.ProcessStateId);

            builder.ToTable("tblEstadoProceso");

            builder.Property(e => e.ProcessStateId).ValueGeneratedNever();
        }
    }
}
