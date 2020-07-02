using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class EmailFormatConfiguration : IEntityTypeConfiguration<EmailFormat>
    {
        public void Configure(EntityTypeBuilder<EmailFormat> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.MenuCodeId, e.EmailId });

            builder.ToTable("tblFormatosEmail");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(1500);

            builder.Property(e => e.EmailBody).IsRequired();

            builder.Property(e => e.Subject).HasMaxLength(450);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.EmailFormats)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblFormatosEmail_tblEmpresa");
        }
    }
}
