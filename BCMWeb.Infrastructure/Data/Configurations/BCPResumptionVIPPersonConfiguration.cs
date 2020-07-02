using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCPResumptionVIPPersonConfiguration : IEntityTypeConfiguration<BCPResumptionVIPPerson>
    {
        public void Configure(EntityTypeBuilder<BCPResumptionVIPPerson> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId, e.PersonId });

            builder.ToTable("tblBCPReanudacionPersonaClave");

            builder.HasIndex(e => new { e.CompanyId, e.ChiefKeyPersonId })
                .HasName("IX_FK_tblPersona_tblReanudacionPersonaClave_FK1");

            builder.Property(e => e.BCPDocumentId).HasColumnName("IdDocumentoBCP");

            builder.Property(e => e.PersonId).ValueGeneratedOnAdd();

            builder.Property(e => e.Activity)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.IdentificationDocument)
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

            builder.HasOne(d => d.BCPDocumentInfo)
                .WithMany(p => p.BCPRestartVIPPersons)
                .HasForeignKey(d => new { d.CompanyId, d.BCPDocumentId })
                .HasConstraintName("FK_tblBCPDocumento_tblBCPReanudacionPersonaClave_FK1");

            builder.HasOne(d => d.PersonInfo)
                .WithMany(p => p.BPERestartVIPPersons)
                .HasForeignKey(d => new { d.CompanyId, d.ChiefKeyPersonId })
                .HasConstraintName("FK_tblPersona_tblReanudacionPersonaClave_FK1");
        }
    }
}
