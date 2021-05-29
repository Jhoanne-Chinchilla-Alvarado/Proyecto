using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Usuario;
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
            builder.Property(c => c.nombreusuario)
                .HasMaxLength(100);
            builder.Property(c => c.num_documento)
                .HasMaxLength(50);
            builder.Property(c => c.email)
                .HasMaxLength(100);
            builder.Property(c => c.password_hash)
                .HasMaxLength(50);
            builder.Property(c => c.password_salt)
                .HasMaxLength(100);
            
        }
    }
}
