using Proyecto.Entidades.Ingresos;
using Proyecto.Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades.Usuario
{
    public class Usuario
    {
        public int idusuario { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El nombre Usuario debe tener un Máximo de 100 o Mínimo 10 carácteres.")]
        public string nombreusuario { get; set; }
        public string num_documento { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "Correo sobrepasa Límite permitido de 50 caracteres")]
        public string email { get; set; }
        public byte password_hash { get; set; }
        public byte password_salt { get; set; }
    
        public List<Venta> Ventas { get; set; }
        public List<Usuari> Usuarios { get; set; }
        public List<Ingreso> Ingresos { get; set; }
        
    }
}
