using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Usuario
{
    public class Usuari
    {
        public int idUsuari { get; set; }

        public string tipo_documento { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 25, ErrorMessage = "La Dirección Máximo de carácteres 70 o Mínimo 25.")]
        public string direccionusuario { get; set; }
        public bool condicion { get; set; }
    }
}
