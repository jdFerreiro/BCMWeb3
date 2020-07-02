using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class IniciativeAttachConfiguration : IEntityTypeConfiguration<IniciativeAttach>
    {
        public void Configure(EntityTypeBuilder<IniciativeAttach> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.IniciativeId, e.AttachId });

            builder.ToTable("tblIniciativas_Anexo");

            builder.Property(e => e.AttachId).ValueGeneratedOnAdd();

            builder.Property(e => e.CreatedDate)
                .HasColumnName("fechaRegistro")
                .HasColumnType("datetime");

            builder.Property(e => e.Name).HasMaxLength(1500);

            builder.Property(e => e.FilePath).HasMaxLength(1500);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.InitiativesAttachments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblIniciativas_Anexo_tblEmpresa");
        }
    }
}
