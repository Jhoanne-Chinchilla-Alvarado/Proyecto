using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Almacen
{
     public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria")
                .HasKey(a => a.Idcategoria);
            builder.Property(a => a.Nombrecategoria)
                .HasMaxLength(50);
           
        }
    }
    }
