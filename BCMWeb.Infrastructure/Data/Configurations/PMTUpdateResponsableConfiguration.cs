using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PMTUpdateResponsableConfiguration : IEntityTypeConfiguration<PMTUpdateResponsable>
    {
        public void Configure(EntityTypeBuilder<PMTUpdateResponsable> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.MenuItemId, e.MessageId });

            builder.ToTable("tblPMTResponsableUpdate");

            builder.Property(e => e.MessageId).ValueGeneratedOnAdd();

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.PMTResponsibleUpdates)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTResponsableUpdate_tblEmpresa");

            builder.HasOne(d => d.MenuOptionInfo)
                .WithMany(p => p.PMTResponsibleUpdates)
                .HasForeignKey(d => new { d.CompanyId, d.MenuItemId })
                .HasConstraintName("FK_tblPMTResponsableUpdate_tblModulo");
        }
    }
}
