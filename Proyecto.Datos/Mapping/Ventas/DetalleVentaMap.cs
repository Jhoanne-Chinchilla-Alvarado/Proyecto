using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.DetalleVenta;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.DetalleVentas
{
    public class DetalleVentaMap : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta")
                .HasKey(c => c.idDetalleVenta);
            builder.Property(c => c.cantidadventas)
                .HasMaxLength(50);
            builder.Property(c => c.idventa)
                .HasMaxLength(256);
            
        }
    }
}
