using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Ingreso;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Ingresos
{
    public class IngresoMap : IEntityTypeConfiguration<Ingreso>
    {
        public void Configure(EntityTypeBuilder<Ingreso> builder)
        {
            builder.ToTable("Ingreso")
                .HasKey(c => c.idingreso);
            builder.Property(c => c.numerocomprobante)
                .HasMaxLength(50);
            builder.Property(c => c.seriecomprobante)
                .HasMaxLength(256);
            builder.Property(c => c.tipocomprobante)
                .HasMaxLength(50);
            builder.Property(c => c.fechaHora)
                .HasMaxLength(256);
            builder.Property(c => c.estado)
                .HasMaxLength(50);
            builder.Property(c => c.impuesto)
                .HasMaxLength(256);
        }
    }
}
