using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.PositionId });

            builder.ToTable("tblCargo");

            builder.Property(e => e.PositionId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.EmployeePositions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresa_tblCargo_FK1");
        }
    }
}
