using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class TableTypeContentConfiguration : IEntityTypeConfiguration<TableTypeContent>
    {
        public void Configure(EntityTypeBuilder<TableTypeContent> builder)
        {
            builder.HasKey(e => e.TableTypeContentId);

            builder.ToTable("tblTipoTablaContenido");

            builder.Property(e => e.TableTypeContentId).ValueGeneratedNever();
        }
    }
}
