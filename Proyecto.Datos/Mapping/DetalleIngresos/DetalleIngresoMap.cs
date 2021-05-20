using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.DetalleIngreso;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Compra
{
    public class DetalleIngresoMap : IEntityTypeConfiguration<DetalleIngreso>
    {
        public void Configure(EntityTypeBuilder<DetalleIngreso> builder)
        {
            builder.ToTable("DetalleIngreso")
                .HasKey(c => c.idDetalleingreso);
            builder.Property(c => c.precioDetalle)
                .HasMaxLength(50);
            builder.Property(c => c.cantidad)
                .HasMaxLength(256);
        }
    }
}
