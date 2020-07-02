using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class UserStateConfiguration : IEntityTypeConfiguration<UserState>
    {
        public void Configure(EntityTypeBuilder<UserState> builder)
        {
            builder.HasKey(e => e.UserStateId);

            builder.ToTable("tblEstadoUsuario");

            builder.Property(e => e.UserStateId).ValueGeneratedNever();
        }
    }
}
