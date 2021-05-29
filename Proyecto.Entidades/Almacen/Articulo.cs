using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Almacen
{
    public class Articulo
    {
        public int idarticulo { get; set; }
    
        
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El nombre Articulo debe tener un Máximo de 100 o Mínimo 10 carácteres.")]
        public string nombrearticulo { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 25, ErrorMessage = "La descripción Máximo de carácteres 70 o Mínimo 25.")]
        public string descripcionarticulo;
        public bool condicionarticulo { get; set; }

        //implementacion de la tabla categoria 
        public List<Categoria> Categorias { get; set; }

    }
}
