using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico3.Dato;

namespace TrabajoPractico3.Modelo
{
    public class Pais
    {
        public string Codigo { get; set; }
        public String Nombre { get; set; }
        public long Poblacion { get; set; }

        public Pais(String _Codigo, String _Nombre, long _Poblacion)
        {
            Codigo = _Codigo;
            Nombre = Encoding.UTF8.GetString(Encoding.Default.GetBytes(_Nombre));
            Poblacion = _Poblacion;
        }
        public override string ToString()
        {
            return Nombre;
        }
        public static Dictionary<String, Pais> Paises { get; set; }
        public static void cargarPaises()
        {
            new PaisDAO().CargarTODO();
        }
    }
}
