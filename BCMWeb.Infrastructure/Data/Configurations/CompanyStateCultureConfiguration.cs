using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CompanyStateCultureConfiguration : IEntityTypeConfiguration<CompanyStateCulture>
    {
        public void Configure(EntityTypeBuilder<CompanyStateCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.CompanyStateId });

            builder.ToTable("tblCultura_EstadoEmpresa");

            builder.HasIndex(e => e.CompanyStateId)
                .HasName("IX_FK_tblCultura_EstadoEmpresa_tblEstadoEmpresa");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(d => d.CompanyStateInfo)
                .WithMany(p => p.CompanyStateCultures)
                .HasForeignKey(d => d.CompanyStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_EstadoEmpresa_tblEstadoEmpresa");
        }
    }
}
