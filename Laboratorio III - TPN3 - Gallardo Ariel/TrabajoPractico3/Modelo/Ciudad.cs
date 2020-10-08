using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico3.Dato;

namespace TrabajoPractico3.Modelo
{
    public class Ciudad
    {
        public String Nombre { get; set; }
        public long Poblacion { get; set; }
        public Pais Pais { get; set; }

        public Ciudad(String _Nombre, long _Poblacion, Pais _Pais)
        {
            Nombre = Encoding.UTF8.GetString(Encoding.Default.GetBytes(_Nombre));
            Poblacion = _Poblacion;
            Pais = _Pais;
        }

        public static List<Ciudad> Ciudades { get; set; }
        public static void cargarCiudades()
        {
            new CiudadDAO().CargarTODO();
        }

        public static void BuscarCiudad(String _Ciudad, String Poblacion, String _Pais)
        {
            new CiudadDAO().BuscarCiudad(_Ciudad, Poblacion, _Pais);
        }

        public static void ModificarCiudad(String _Nombre, String _Poblacion, String _Pais, int Seleccion)
        {
            String codViejo = Ciudad.Ciudades[Seleccion].Pais.Codigo;
            Ciudad.Ciudades[Seleccion].Nombre = _Nombre;
            Ciudad.Ciudades[Seleccion].Poblacion = long.Parse(_Poblacion);
            Ciudad.Ciudades[Seleccion].Pais = Pais.Paises[_Pais];
            new CiudadDAO().Actualizar(Ciudad.Ciudades[Seleccion], codViejo);
        }

        public void CrearCiudad()
        {
            new CiudadDAO().Crear(this);
        }

        public void EliminarCiudad()
        {
            new CiudadDAO().Eliminar(this);
        }
    }
}
