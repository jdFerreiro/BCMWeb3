using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PersonPhoneConfiguration : IEntityTypeConfiguration<PersonPhone>
    {
        public void Configure(EntityTypeBuilder<PersonPhone> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.PersonId, e.PersonPhoneId });

            builder.ToTable("tblPersonaTelefono");

            builder.HasIndex(e => e.PhoneTypeId)
                .HasName("IX_FK_tblPersonaTelefono_tblTipoTelefono");

            builder.Property(e => e.PersonPhoneId).ValueGeneratedOnAdd();

            builder.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.PhoneTypeInfo)
                .WithMany(p => p.PhonePersons)
                .HasForeignKey(d => d.PhoneTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPersonaTelefono_tblTipoTelefono");

            builder.HasOne(d => d.PersonInfo)
                .WithMany(p => p.PersonPhones)
                .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                .HasConstraintName("FK_tblPersona_tblPersonaTelefono_FK1");
        }
    }
}
