using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DocumentStateConfiguration : IEntityTypeConfiguration<DocumentState>
    {
        public void Configure(EntityTypeBuilder<DocumentState> builder)
        {
            builder.HasKey(e => e.DocumentStateId);

            builder.ToTable("tblEstadoDocumento");

            builder.Property(e => e.DocumentStateId).ValueGeneratedNever();
        }
    }
}
