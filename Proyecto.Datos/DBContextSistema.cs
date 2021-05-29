using Microsoft.EntityFrameworkCore;
using Proyecto.Datos.Mapping.Almacen;
using Proyecto.Datos.Mapping.Articulos;
using Proyecto.Datos.Mapping.DetalleVentas;
using Proyecto.Datos.Mapping.Ingresos;
using Proyecto.Datos.Mapping.Personas;
using Proyecto.Datos.Mapping.Roles;
using Proyecto.Datos.Mapping.Telefono;
using Proyecto.Datos.Mapping.Usuarios;
using Proyecto.Datos.Mapping.Ventas;
using Proyecto.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos
{
    public class DBContextSistema : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public object Telefonos { get; set; }

        public DBContextSistema(DbContextOptions<DBContextSistema> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ArticulosMap());
            modelBuilder.ApplyConfiguration(new ArticuMap());
            modelBuilder.ApplyConfiguration(new DetalleIngresoMap());
            modelBuilder.ApplyConfiguration(new IngresoMap());
            modelBuilder.ApplyConfiguration(new IngresosMap());
            modelBuilder.ApplyConfiguration(new PersonaMap());
            modelBuilder.ApplyConfiguration(new PersonasMap());
            modelBuilder.ApplyConfiguration(new RolMap());
            modelBuilder.ApplyConfiguration(new TelefonosMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new UsuariosMap());
            modelBuilder.ApplyConfiguration(new DetalleVentaMap());
            modelBuilder.ApplyConfiguration(new DetalleVentasMap());
            modelBuilder.ApplyConfiguration(new VentaMap());
            modelBuilder.ApplyConfiguration(new VentasMap());
            


        }

    }
}