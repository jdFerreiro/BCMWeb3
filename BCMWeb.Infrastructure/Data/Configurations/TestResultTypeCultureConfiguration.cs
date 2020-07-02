using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class TestResultTypeCultureConfiguration : IEntityTypeConfiguration<TestResultTypeCulture>
    {
        public void Configure(EntityTypeBuilder<TestResultTypeCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.TestResultTypeId });

            builder.ToTable("tblCultura_TipoResultadoPrueba");

            builder.HasIndex(e => e.TestResultTypeId)
                .HasName("IX_FK_tblCultura_TipoResultadoPrueba_tblTipoResultadoPrueba");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.TestResultTypeInfo)
                .WithMany(p => p.TestResultTypeCultures)
                .HasForeignKey(d => d.TestResultTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_TipoResultadoPrueba_tblTipoResultadoPrueba");
        }
    }
}
