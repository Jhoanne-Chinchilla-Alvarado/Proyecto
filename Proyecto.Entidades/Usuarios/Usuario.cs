using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Usuarios
{
    public class Usuario
    {
        public int idusuario { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El nombre Usuario debe tener un Máximo de 100 o Mínimo 10 carácteres.")]
        public string nombre { get; set; }
        public string tipo_documento { get; set; }
        public string num_documento { get; set; }
        [StringLength(70, MinimumLength = 25, ErrorMessage = "La Dirección Máximo de carácteres 70 o Mínimo 25.")]
        public string direccion { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "Recuerde Número de teléfono debe contener Mínimo 11 digitos")]
        public string telefono { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "Correo sobrepasa Límite permitido de 50 caracteres")]
        public string email { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 25, ErrorMessage = "La contraseña hash Máximo de carácteres 70 o Mínimo 25.")]
        public string password_hash { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 25, ErrorMessage = "La contraseña salt Máximo de carácteres 70 o Mínimo 25.")]
        public string password_salt { get; set; }
        public bool condicion { get; set; }
    }
}
