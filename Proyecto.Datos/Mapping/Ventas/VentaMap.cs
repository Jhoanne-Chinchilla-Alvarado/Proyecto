using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Ventas
{
    public class VentaMap : IEntityTypeConfiguration<Entidades.Ventas.DetalleVentas>
    {
        public void Configure(EntityTypeBuilder<Entidades.Ventas.DetalleVentas> builder)
        {
            builder.ToTable("Venta")
                .HasKey(c => c.idventa);
            builder.Property(c => c.numerocomprobante)
                .HasMaxLength(50);
            builder.Property(c => c.seriecomprobante)
                .HasMaxLength(256);
            builder.Property(c => c.tipocomprobante)
                .HasMaxLength(50);
            builder.Property(c => c.impuesto)
                .HasMaxLength(256);
            builder.Property(c => c.total)
                .HasMaxLength(256);
        }
    }
}
