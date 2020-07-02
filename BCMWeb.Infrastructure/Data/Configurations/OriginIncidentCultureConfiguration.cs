using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class OriginIncidentCultureConfiguration : IEntityTypeConfiguration<OriginIncidentCulture>
    {
        public void Configure(EntityTypeBuilder<OriginIncidentCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.OriginIncidentId });

            builder.ToTable("tblCulture_NaturalezaIncidente");

            builder.HasIndex(e => e.OriginIncidentId)
                .HasName("IX_FK_tblCulture_NaturalezaIncidente_tblNaturalezaIncidente");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(250);

            builder.HasOne(d => d.OriginIncidentInfo)
                .WithMany(p => p.OriginIncidentCultures)
                .HasForeignKey(d => d.OriginIncidentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCulture_NaturalezaIncidente_tblNaturalezaIncidente");
        }
    }
}
