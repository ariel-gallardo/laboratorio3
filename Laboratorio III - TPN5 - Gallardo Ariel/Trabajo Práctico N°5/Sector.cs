using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_N_5
{
    class Sector
    {
        public long Id { get; set; }
        public String Denominacion { get; set; }
        public Double valorSemaforo { get; set; }
        public String colorSemaforo { get; set; }

        public Sector(long id, string denominacion, double valorSemaforo, string colorSemaforo)
        {
            Id = id;
            Denominacion = denominacion;
            this.valorSemaforo = valorSemaforo;
            this.colorSemaforo = colorSemaforo;
        }

        public override string ToString()
        {
            return
            "\tSector\n\t******\n" +
            "\tId: " + Id + '\n' +
            "\tDenominacion: " + Denominacion + '\n' +
            "\tValor Semaforo: " + valorSemaforo + '\n' +
            "\tColor Semaforo: " + colorSemaforo;
        }
    }
}
