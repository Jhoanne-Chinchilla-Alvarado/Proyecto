using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Persona;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Personas
{
    class PersonasMap : IEntityTypeConfiguration<Persons>
    {
        public void Configure(EntityTypeBuilder<Persons> builder)
        {
            builder.ToTable("Personas")
                .HasKey(c => c.idPersons);
            builder.Property(c => c.tipoPersona)
                .HasMaxLength(20);
            builder.Property(c => c.tipodocumento)
                .HasMaxLength(50);
            builder.Property(c => c.direccion)
               .HasMaxLength(70);
     

        }
    }
}
