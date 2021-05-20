using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Persona;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Personas
{
    public class PersonaMap : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Persona")
                .HasKey(c => c.idpersona);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            builder.Property(c => c.tipoPersona)
                .HasMaxLength(256);
        }
    }
}
