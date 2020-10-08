using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_N_6.JsonURL
{
    public class Name
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }

        public Name(string title, string first, string last)
        {
            this.title = title;
            this.first = first;
            this.last = last;
        }
    }
}
