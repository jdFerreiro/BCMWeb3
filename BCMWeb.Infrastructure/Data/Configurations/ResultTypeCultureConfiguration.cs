using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class ResultTypeCultureConfiguration : IEntityTypeConfiguration<ResultTypeCulture>
    {
        public void Configure(EntityTypeBuilder<ResultTypeCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.ResultTypeId });

            builder.ToTable("tblCultura_TipoRespaldo");

            builder.HasIndex(e => e.ResultTypeId)
                .HasName("IX_FK_tblCultura_TipoRespaldo_tblTipoRespaldo");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.ResultTypeInfo)
                .WithMany(p => p.ResultTypeCultures)
                .HasForeignKey(d => d.ResultTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_TipoRespaldo_tblTipoRespaldo");
        }
    }
}
