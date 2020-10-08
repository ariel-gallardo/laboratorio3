using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_N_6.JsonURL
{
    public class Street
    {
        public int number { get; set; }
        public string name { get; set; }

        public Street(int number, string name)
        {
            this.number = number;
            this.name = name;
        }
    }
}
