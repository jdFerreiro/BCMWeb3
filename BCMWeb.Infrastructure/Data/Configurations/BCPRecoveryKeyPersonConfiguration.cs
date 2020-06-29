using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCPRecoveryKeyPersonConfiguration : IEntityTypeConfiguration<BCPRecoveryKeyPerson>
    {
        public void Configure(EntityTypeBuilder<BCPRecoveryKeyPerson> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId, e.PersonId });

            builder.ToTable("tblBCPRecuperacionPersonaClave");

            builder.HasIndex(e => new { e.CompanyId, e.ChiefKeyPersonalId })
                .HasName("IX_FK_tblPersona_tblBCPRecuperacionPersonaClave_FK1");

            builder.Property(e => e.BCPDocumentId).HasColumnName("IdDocumentoBCP");

            builder.Property(e => e.PersonId).ValueGeneratedOnAdd();

            builder.Property(e => e.Activity)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.GovermentDocumentId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.RoomAddress).IsRequired();

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
                .WithMany(p => p.BCPRestartKeyPersons)
                .HasForeignKey(d => new { d.CompanyId, d.BCPDocumentId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBCPDocumento_tblBCPRecuperacionPersonaClave_FK1");

            builder.HasOne(d => d.PersonInfo)
                .WithMany(p => p.BCPRecoverVIPPersons)
                .HasForeignKey(d => new { d.CompanyId, d.ChiefKeyPersonalId })
                .HasConstraintName("FK_tblPersona_tblBCPRecuperacionPersonaClave_FK1");
        }
    }
}
