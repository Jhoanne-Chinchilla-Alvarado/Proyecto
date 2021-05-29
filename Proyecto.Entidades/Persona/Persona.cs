using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Persona
{
    public class Persona
    {
        public int idpersona { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "Recuerde Número de teléfono debe contener Mínimo 11 digitos")]
        public string idtelefono { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El nombre Usuario debe tener un Máximo de 100 o Mínimo 10 carácteres.")]
        public string nombrepersona { get; set; }
        public string numerodocumento { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "Correo sobrepasa Límite permitido de 50 caracteres")]
        public string email { get; set; }

        public List<Person> Personas { get; set; }
        public List<Telefono> Telefonos { get; set; }
    }
}
