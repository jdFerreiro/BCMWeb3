using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CountryStateConfiguration : IEntityTypeConfiguration<CountryState>
    {
        public void Configure(EntityTypeBuilder<CountryState> builder)
        {
            builder.HasKey(e => new { e.CountryId, e.CountryStateId });

            builder.ToTable("tblEstado");

            builder.HasOne(d => d.CountryInfo)
                .WithMany(p => p.CountryStates)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPais_tblEstado_FK1");
        }
    }
}
