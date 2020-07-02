using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PersonEmailConfiguration : IEntityTypeConfiguration<PersonEmail>
    {
        public void Configure(EntityTypeBuilder<PersonEmail> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.PersonId, e.PersonEmailId });

            builder.ToTable("tblPersonaCorreo");

            builder.HasIndex(e => e.EmailTypeId)
                .HasName("IX_FK_tblPersonaCorreo_tblTipoCorreo");

            builder.Property(e => e.PersonEmailId).ValueGeneratedOnAdd();

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.EmailTypeInfo)
                .WithMany(p => p.EmailPersons)
                .HasForeignKey(d => d.EmailTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPersonaCorreo_tblTipoCorreo");

            builder.HasOne(d => d.PersonInfo)
                .WithMany(p => p.PersonEmails)
                .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                .HasConstraintName("FK_tblPersonaCorreo_tblPersona");
        }
    }
}
