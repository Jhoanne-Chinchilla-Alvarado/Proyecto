using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Ventas
{
    public class DetalleVentasMap : IEntityTypeConfiguration<DetalleVent>
    {
        public void Configure(EntityTypeBuilder<DetalleVent> builder)
        {
            builder.ToTable("DetalleVentas")
                .HasKey(c => c.idDetalleVent);
            builder.Property(c => c.precioventas)
                .HasMaxLength(50);
            builder.Property(c => c.descuentoventas)
                .HasMaxLength(256);

        }
    }
}
