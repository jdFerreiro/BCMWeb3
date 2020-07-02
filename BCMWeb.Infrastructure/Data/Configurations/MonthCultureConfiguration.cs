using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class MonthCultureConfiguration : IEntityTypeConfiguration<MonthCulture>
    {
        public void Configure(EntityTypeBuilder<MonthCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.MonthId });

            builder.ToTable("tblCultura_Mes");

            builder.HasIndex(e => e.MonthId)
                .HasName("IX_FK_tblCultura_Mes_tblMes");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.MonthInfo)
                .WithMany(p => p.MonthCultures)
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_Mes_tblMes");
        }
    }
}
