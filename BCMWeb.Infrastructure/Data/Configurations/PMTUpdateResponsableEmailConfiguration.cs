using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PMTUpdateResponsableEmailConfiguration : IEntityTypeConfiguration<PMTUpdateResponsableEmail>
    {
        public void Configure(EntityTypeBuilder<PMTUpdateResponsableEmail> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.MenuOptionId, e.MessageId, e.UserId });

            builder.ToTable("tblPMTResponsableUpdate_Correo");

            builder.HasIndex(e => e.UserId)
                .HasName("IX_FK_tblPMTResponsableUpdate_Correo_tblUsuario");

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.MaintenancePlanUpdateEmails)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTResponsableUpdate_Correo_tblUsuario");

            builder.HasOne(d => d.PMTUpdateResponsableInfo)
                .WithMany(p => p.PMTUpdateResponsableEmails)
                .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId, d.MessageId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTResponsableUpdate_Correo_tblPMTResponsableUpdate");
        }
    }
}
