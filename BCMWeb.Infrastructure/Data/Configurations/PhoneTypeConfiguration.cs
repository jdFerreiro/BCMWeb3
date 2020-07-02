using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PhoneTypeConfiguration : IEntityTypeConfiguration<PhoneType>
    {
        public void Configure(EntityTypeBuilder<PhoneType> builder)
        {
            builder.HasKey(e => e.PhoneTypeId);

            builder.ToTable("tblTipoTelefono");

            builder.Property(e => e.PhoneTypeId).ValueGeneratedNever();
        }
    }
}
