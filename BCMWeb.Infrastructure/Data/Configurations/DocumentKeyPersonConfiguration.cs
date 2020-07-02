using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DocumentKeyPersonConfiguration : IEntityTypeConfiguration<DocumentKeyPerson>
    {
        public void Configure(EntityTypeBuilder<DocumentKeyPerson> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.PersonId });

            builder.ToTable("tblDocumentoPersonaClave");

            builder.HasIndex(e => new { e.CompanyId, e.PersonId })
                .HasName("IX_FK_tblDocumentoPersonaClave_tblPersona");

            builder.Property(e => e.GovermentId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.HomeAddress).IsRequired();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.MobilePhoneNumber)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.HomePhoneNumber)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.OfficePhoneNumber)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.DocVIPPersons)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPersonaClave_tblEmpresa");

            builder.HasOne(d => d.PersonInfo)
                .WithMany(p => p.DocVIPPersons)
                .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDocumentoPersonaClave_tblPersona");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.DocumentVIPPersons)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDocumentoPersonaClave_tblDocumento");
        }
    }
}
