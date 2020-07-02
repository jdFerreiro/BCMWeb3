using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CountryStateCultureConfiguration : IEntityTypeConfiguration<CountryStateCulture>
    {
        public void Configure(EntityTypeBuilder<CountryStateCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.CountryId, e.CountryStateId });

            builder.ToTable("tblCultura_Estado");

            builder.HasIndex(e => new { e.CountryId, e.CountryStateId })
                .HasName("IX_FK_tblCultura_Estado_tblEstado");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Name).HasMaxLength(250);

            builder.HasOne(d => d.CountryStateInfo)
                .WithMany(p => p.CountryStateCultures)
                .HasForeignKey(d => new { d.CountryId, d.CountryStateId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_Estado_tblEstado");
        }
    }
}
