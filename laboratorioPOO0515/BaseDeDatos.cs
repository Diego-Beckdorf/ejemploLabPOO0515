using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorioPOO0515
{
    public class BaseDeDatos
    {
        List<Usuario> usuarios;
        List<Publicacion> publicaciones;
        List<Comentario> comentarios;

        public BaseDeDatos()
        {
            usuarios = new List<Usuario>();
            publicaciones = new List<Publicacion>();
            comentarios = new List<Comentario>();
        }
    }
}
