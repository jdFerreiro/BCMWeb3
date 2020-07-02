using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class ScaleConfiguration : IEntityTypeConfiguration<Scale>
    {
        public void Configure(EntityTypeBuilder<Scale> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScaleId });

            builder.ToTable("tblEscala");

            builder.HasIndex(e => new { e.CompanyId, e.ScaleTypeId })
                .HasName("IX_FK_tblEscala_tblTipoEscala");

            builder.Property(e => e.Description).IsRequired();

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.Scales)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresa_tblEscala_FK1");

            builder.HasOne(d => d.ScaleTypeInfo)
                .WithMany(p => p.Scales)
                .HasForeignKey(d => new { d.CompanyId, d.ScaleTypeId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEscala_tblTipoEscala");
        }
    }
}
