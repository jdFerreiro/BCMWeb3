using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class EmailTypeConfiguration : IEntityTypeConfiguration<EmailType>
    {
        public void Configure(EntityTypeBuilder<EmailType> builder)
        {
            builder.HasKey(e => e.EmailTypeId);

            builder.ToTable("tblTipoCorreo");

            builder.Property(e => e.EmailTypeId).ValueGeneratedNever();
        }
    }
}
