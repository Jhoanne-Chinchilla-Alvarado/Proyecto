using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Persona
{
    public class Rol
    {
        public int idrol { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El nombre Usuario debe tener un Máximo de 100 o Mínimo 10 carácteres.")]
        public string nombrerol { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "La descripción Máximo de carácteres 100 o Mínimo 25.")]
        public string descripcionrol { get; set; }
        public bool condicion { get; set; }

        public List<Usuario> Usuario { get; set; }
    }
}
