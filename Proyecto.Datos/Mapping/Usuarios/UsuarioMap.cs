using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Usuarios
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario")
                .HasKey(c => c.idusuario);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            builder.Property(c => c.condicion)
                .HasMaxLength(256);
        }
    }
}
