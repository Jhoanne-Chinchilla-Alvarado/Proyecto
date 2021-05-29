using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Usuarios
{
    class UsuariosMap : IEntityTypeConfiguration<Usuari>
    {
        public void Configure(EntityTypeBuilder<Usuari> builder)
        {
            builder.ToTable("Usuarios")
                .HasKey(c => c.idUsuari);
            builder.Property(c => c.tipo_documento)
                .HasMaxLength(50);
            builder.Property(c => c.direccionusuario)
                .HasMaxLength(70);
            builder.Property(c => c.condicion)
                .HasMaxLength(256);

        }
    }
}