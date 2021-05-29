using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Ingresos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Ingresos
{
    public class IngresosMap : IEntityTypeConfiguration<Ingres>
    {
        public void Configure(EntityTypeBuilder<Ingres> builder)
        {
            builder.ToTable("Ingresos")
                .HasKey(c => c.idIngre);
            builder.Property(c => c.condicioningreso)
                .HasMaxLength(50);
            builder.Property(c => c.totalingreso)
                .HasMaxLength(50);
           
        }
    }
}
