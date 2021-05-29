using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Ventas
{
    class VentasMap : IEntityTypeConfiguration<Vent>
    {
        public void Configure(EntityTypeBuilder<Vent> builder)
        {
            builder.ToTable("Ventas")
                .HasKey(c => c.idVent);
            builder.Property(c => c.idUsuario)
                .HasMaxLength(50);
            builder.Property(c => c.idPersona)
                .HasMaxLength(56);
            builder.Property(c => c.idUsuario)
                .HasMaxLength(50);
            builder.Property(c => c.seriecomprobante)
                .HasMaxLength(56);
            builder.Property(c => c.numerocomprobante)
                .HasMaxLength(50);
            builder.Property(c => c.fechaHora)
                .HasMaxLength(56);
        }
    }
}
