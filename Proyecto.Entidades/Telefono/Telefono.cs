using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades.Telefono
{
    public class Telefon
    {
        public int idTelefon { get; set; }

        public string telefonopersona { get; set; }
        public string telefonoresidencial { get; set; }
        public string telefonolaboral { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
