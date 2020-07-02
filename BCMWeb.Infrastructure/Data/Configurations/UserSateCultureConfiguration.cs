using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class UserSateCultureConfiguration : IEntityTypeConfiguration<UserSateCulture>
    {
        public void Configure(EntityTypeBuilder<UserSateCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.UserStateId });

            builder.ToTable("tblCultura_EstadoUsuario");

            builder.HasIndex(e => e.UserStateId)
                .HasName("IX_FK_tblCultura_EstadoUsuario_tblEstadoUsuario");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.UserStateInfo)
                .WithMany(p => p.UserStateCultures)
                .HasForeignKey(d => d.UserStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_EstadoUsuario_tblEstadoUsuario");
        }
    }
}
