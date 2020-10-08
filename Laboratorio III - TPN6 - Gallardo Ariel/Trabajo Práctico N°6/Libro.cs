using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_N_6
{
    class Libro
    {
        public long Id { get; set; }
        public String Nombre { get; set; }
        public int AnioPublicacion { get; set; }
        public String Editorial { get; set; }

        public Libro(long id, string nombre, int anioPublicacion, string editorial)
        {
            Id = id;
            Nombre = nombre;
            AnioPublicacion = anioPublicacion;
            Editorial = editorial;
        }
    }
}
