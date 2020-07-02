using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PMTMessageUpdateConfiguration : IEntityTypeConfiguration<PMTMessageUpdate>
    {
        public void Configure(EntityTypeBuilder<PMTMessageUpdate> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.MessageId, e.MenuOptionId });

            builder.ToTable("tblPMTMensajeActualizacion");

            builder.HasIndex(e => new { e.CompanyId, e.MenuOptionId })
                .HasName("IX_FK_tblPMTMensajeActualizacion_tblModulo");

            builder.Property(e => e.MessageId).ValueGeneratedOnAdd();

            builder.Property(e => e.UpdateDate).HasColumnType("datetime");

            builder.Property(e => e.LastConsignmentDate).HasColumnType("datetime");

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.PMTMessageUpdates)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTMensajeActualizacion_tblEmpresa");

            builder.HasOne(d => d.MenuOptionInfo)
                .WithMany(p => p.PMTMessageUpdates)
                .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId })
                .HasConstraintName("FK_tblPMTMensajeActualizacion_tblModulo");
        }
    }
}
