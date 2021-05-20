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
            builder.ToTable("DetalleVentas")
                .HasKey(c => c.idDetalleventa);
            builder.Property(c => c.precioDetalleventa)
                .HasMaxLength(50);
            builder.Property(c => c.cantidad)
                .HasMaxLength(256);
            builder.Property(c => c.descuento)
                .HasMaxLength(256);
        }
    }
}
