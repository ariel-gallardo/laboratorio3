using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_N_5
{
    class Empleado
    {
        public long Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public long Cuil { get; set; }
        public Sector Sector { get; set; }
        public double CupoAsignado { get; set; }
        public double CupoConsumido { get; set; }

        public Empleado()
        {
        }

        public Empleado(long id, string nombre, string apellido, long cuil, Sector sector, double cupoAsignado, double cupoConsumido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Cuil = cuil;
            Sector = sector;
            CupoAsignado = cupoAsignado;
            CupoConsumido = cupoConsumido;
        }

        public override string ToString()
        {
            return
            "Empleado\n********\n" +
            "Id: " + Id + '\n' +
            "Nombre: " + Nombre + '\n' +
            "Apellido: " + Apellido + '\n' +
            "Cuil: " + Cuil + '\n' +
            Sector + '\n' +
            "CupoAsignado: " + CupoAsignado + '\n' +
            "CupoConsumido: " + CupoConsumido + '\n';
        }
    }
}
