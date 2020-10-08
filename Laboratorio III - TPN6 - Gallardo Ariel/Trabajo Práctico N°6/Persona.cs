using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_N_6
{
    class Persona
    {
        public long Id { get; set; }
        public String Apellido { get; set; }
        public String Nombre { get; set; }
        public long Dni { get; set; }
        public List<Libro> Libros { get; set; }

        public Persona(long id, string apellido, string nombre, long dni, List<Libro> libros)
        {
            Id = id;
            Apellido = apellido;
            Nombre = nombre;
            Dni = dni;
            this.Libros = libros;
        }
    }
}
