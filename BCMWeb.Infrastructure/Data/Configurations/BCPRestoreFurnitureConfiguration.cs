using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCPRestoreFurnitureConfiguration : IEntityTypeConfiguration<BCPRestoreFurniture>
    {
        public void Configure(EntityTypeBuilder<BCPRestoreFurniture> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId, e.BCPRestoreFurnitureId });

            builder.ToTable("tblBCPRestauracionMobiliario");

            builder.Property(e => e.BCPDocumentId).HasColumnName("IdDocumentoBCP");

            builder.Property(e => e.BCPRestoreFurnitureId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.BCPDocumentInfo)
                .WithMany(p => p.BCPRestoreFurnitures)
                .HasForeignKey(d => new { d.CompanyId, d.BCPDocumentId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBCPDocumento_tblBCPRestauracionMobiliario_FK1");
        }
    }
}
