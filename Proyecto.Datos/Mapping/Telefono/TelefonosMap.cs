using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Telefono;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Telefono
{
    public class TelefonosMap : IEntityTypeConfiguration<Telefon>
    {
        public void Configure(EntityTypeBuilder<Telefon> builder)
        {
            builder.ToTable("telefono")
                .HasKey(b => b.idTelefon);
            builder.Property(b => b.telefonopersona)
                .HasMaxLength(100);
            builder.Property(b => b.telefonoresidencial)
                .HasMaxLength(70);
            builder.Property(b => b.telefonolaboral)
                .HasMaxLength(50);
        }
    }
}
