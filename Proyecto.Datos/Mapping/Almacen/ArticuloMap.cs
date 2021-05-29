using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Almacen;

namespace Proyecto.Datos.Mapping.Articulos
{
    public class ArticuMap : IEntityTypeConfiguration<Articulo>
    {
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.ToTable("articulo")
                .HasKey(b => b.idarticulo);
            builder.Property(b => b.nombrearticulo)
                .HasMaxLength(100);
            builder.Property(b => b.descripcionarticulo)
                .HasMaxLength(70);
            builder.Property(b => b.condicionarticulo)
                .HasMaxLength(50);

            builder.HasOne(p => p.Categorias)
                .WithOne();


        }
    }
}