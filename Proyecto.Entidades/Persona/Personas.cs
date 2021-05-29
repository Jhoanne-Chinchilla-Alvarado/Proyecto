using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Persona
{
    public class Persons
    {
        public int idPersons { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El tipo Persona sobrepasa Máximo de 20 carácteres permitidos.")]
        public string tipoPersona { get; set; }
        public string tipodocumento { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 25, ErrorMessage = "La Dirección Máximo de carácteres 70 o Mínimo 25.")]
        public string direccion { get; set; }
    }
}
