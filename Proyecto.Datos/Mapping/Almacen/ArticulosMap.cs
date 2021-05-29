using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Almacen
{
    public class ArticulosMap : IEntityTypeConfiguration<Articu>
    {

        public void Configure(EntityTypeBuilder<Articu> builder)
        {
            builder.ToTable("Articulos")
                .HasKey(c => c.Idarticu);
            builder.Property(c => c.Precioarticulo)
                .HasMaxLength(50);
            builder.Property(c => c.Stock)
                .HasMaxLength(256);
        }

    }
}