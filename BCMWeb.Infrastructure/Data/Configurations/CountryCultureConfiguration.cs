using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CountryCultureConfiguration : IEntityTypeConfiguration<CountryCulture>
    {
        public void Configure(EntityTypeBuilder<CountryCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.CountryId });

            builder.ToTable("tblCultura_Pais");

            builder.HasIndex(e => e.CountryId)
                .HasName("IX_FK_tblCulture_Pais_tblPais");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Name).HasMaxLength(250);

            builder.HasOne(d => d.CountryInfo)
                .WithMany(p => p.CountryCultures)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCulture_Pais_tblPais");
        }
    }
}
