using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CompanyStateConfiguration : IEntityTypeConfiguration<CompanyState>
    {
        public void Configure(EntityTypeBuilder<CompanyState> builder)
        {
            builder.HasKey(e => e.CompanyStateId);

            builder.ToTable("tblEstadoEmpresa");

            builder.Property(e => e.CompanyStateId).ValueGeneratedNever();
        }
    }
}
