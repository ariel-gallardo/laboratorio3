using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_N_6.JsonURL
{
    public class Timezone
    {
        public string offset { get; set; }
        public string description { get; set; }

        public Timezone(string offset, string description)
        {
            this.offset = offset;
            this.description = description;
        }
    }
}
