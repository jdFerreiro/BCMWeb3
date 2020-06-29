using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId);

            builder.ToTable("tblUsuario");

            builder.HasIndex(e => e.UserStateId)
                .HasName("IX_FK_tblUsuario_tblEstadoUsuario");

            builder.Property(e => e.UserStateId).HasColumnName("EstadoUsuario");
            builder.Property(e => e.UserId).HasColumnName("IdUsuario");

            builder.Property(e => e.UserPassw)
                .HasColumnName("ClaveUsuario")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.UserCode)
                .HasColumnName("CodigoUsuario")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Email).HasMaxLength(250);

            builder.Property(e => e.UserStateDateChange)
                .HasColumnName("FechaEstado")
                .HasColumnType("datetime");

            builder.Property(e => e.FirstTime)
                .HasColumnName("PrimeraVez")
                .HasColumnType("boolean");

            builder.Property(e => e.LastConnectionDate)
                .HasColumnName("FechaUltimaConexion")
                .HasColumnType("datetime");

            builder.Property(e => e.Name)
                .HasColumnName("Nombre")
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.UserStateInfo)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.UserStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUsuario_tblEstadoUsuario");
        }
    }
}
