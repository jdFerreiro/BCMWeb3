using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class ProcessStateCultureConfiguration : IEntityTypeConfiguration<ProcessStateCulture>
    {
        public void Configure(EntityTypeBuilder<ProcessStateCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.ProcessStateId });

            builder.ToTable("tblCultura_EstadoProceso");

            builder.HasIndex(e => e.ProcessStateId)
                .HasName("IX_FK_tblCultura_EstadoProceso_tblEstadoProceso");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.ProcessStateInfo)
                .WithMany(p => p.BIAProcessStateCultures)
                .HasForeignKey(d => d.ProcessStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_EstadoProceso_tblEstadoProceso");
        }
    }
}
