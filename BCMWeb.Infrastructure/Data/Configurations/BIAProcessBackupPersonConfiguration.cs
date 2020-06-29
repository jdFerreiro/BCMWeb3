using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAProcessBackupPersonConfiguration : IEntityTypeConfiguration<BIAProcessBackupPerson>
    {
        public void Configure(EntityTypeBuilder<BIAProcessBackupPerson> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.PersonId, e.ProcessId });

            builder.ToTable("tblBIAPersonaRespaldoProceso");

            builder.HasIndex(e => new { e.CompanyId, e.PersonId })
                .HasName("IX_FK_tblBIAPersonaRespaldoProceso_tblPersona");

            builder.HasIndex(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId })
                .HasName("IX_FK_tblBIAPersonaRespaldoProceso_tblBIAProceso");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.HasOne(d => d.PersonInfo)
                .WithMany(p => p.BIABackupProcessPersons)
                .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAPersonaRespaldoProceso_tblPersona");

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAProcessBackupPersons)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAPersonaRespaldoProceso_tblBIAProceso");
        }
    }
}
