using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class AddressTypeConfiguration : IEntityTypeConfiguration<AddressType>
    {
        public void Configure(EntityTypeBuilder<AddressType> builder)
        {
            builder.HasKey(e => e.AddressTypeId);

            builder.ToTable("tblTipoDireccion");

            builder.Property(e => e.AddressTypeId).ValueGeneratedNever();
        }
    }
}
