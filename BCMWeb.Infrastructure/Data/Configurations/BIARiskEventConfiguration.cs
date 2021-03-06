﻿using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIARiskEventConfiguration : IEntityTypeConfiguration<BIARiskEvent>
    {
        public void Configure(EntityTypeBuilder<BIARiskEvent> builder)
        {
            builder.HasKey(e => new { e.RiskEventId, e.CompanyId });

            builder.ToTable("tblBIAEventoRiesgo");

            builder.Property(e => e.RiskEventId).ValueGeneratedOnAdd();
        }
    }
}
