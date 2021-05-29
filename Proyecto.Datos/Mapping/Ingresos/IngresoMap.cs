using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Ingresos;

namespace Proyecto.Datos.Mapping.Ingresos
{
    public class IngresoMap : IEntityTypeConfiguration<Ingreso>
    {
        public void Configure(EntityTypeBuilder<Ingreso> builder)
        {
            builder.ToTable("Ingreso")
                .HasKey(c => c.idingreso);
            builder.Property(c => c.idusuario)
                .HasMaxLength(50);
            builder.Property(c => c.tipocomprobanteingreso)
                .HasMaxLength(50);
            builder.Property(c => c.seriecomprobanteingreso)
                .HasMaxLength(50);
            builder.Property(c => c.numerocomprobanteingreso)
                .HasMaxLength(50);
            builder.Property(c => c.fechaHoraingreso)
                .HasMaxLength(50);
            builder.Property(c => c.impuestoingreso)
                .HasMaxLength(256);
        }
    }
}
