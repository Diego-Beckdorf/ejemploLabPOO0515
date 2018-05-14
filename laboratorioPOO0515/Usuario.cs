using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorioPOO0515
{
    public class Usuario
    {
        private String nombreUsuario;
        private String contrasena;

        public Usuario(String nombreUsuario, String contrasena)
        {
            this.NombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
    }
}
