using Microsoft.EntityFrameworkCore;
using Proyecto.Datos.Mapping.Almacen;
using Proyecto.Datos.Mapping.Compra;
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
        public DBContextSistema(DbContextOptions<DBContextSistema>options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new UsuariosMap());
            modelBuilder.ApplyConfiguration(new VentaMap());
            modelBuilder.ApplyConfiguration(new CompraMap());
            
        }    
    }
}
