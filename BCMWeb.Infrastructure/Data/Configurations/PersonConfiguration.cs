using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.PersonId });

            builder.ToTable("tblPersona");

            builder.HasIndex(e => e.UserId)
                .HasName("IX_FK_tblPersona_tblUsuario");

            builder.HasIndex(e => new { e.CompanyId, e.PositionId })
                .HasName("IX_FK_tblCargo_tblPersona_FK1");

            builder.HasIndex(e => new { e.CompanyId, e.OUId })
                .HasName("IX_FK_tblPersona_tblUnidadOrganizativa");

            builder.Property(e => e.PersonId).ValueGeneratedOnAdd();

            builder.Property(e => e.DocumentIdentificationId).HasMaxLength(50);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.Persons)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresa_tblPersona_FK1");

            builder.HasOne(d => d.UserInfo)
                .WithMany(p => p.Persons)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblPersona_tblUsuario");

            builder.HasOne(d => d.PositionInfo)
                .WithMany(p => p.Persons)
                .HasForeignKey(d => new { d.CompanyId, d.PositionId })
                .HasConstraintName("FK_tblCargo_tblPersona_FK1");

            builder.HasOne(d => d.OUInfo)
                .WithMany(p => p.Persons)
                .HasForeignKey(d => new { d.CompanyId, d.OUId })
                .HasConstraintName("FK_tblPersona_tblUnidadOrganizativa");
        }
    }
}
