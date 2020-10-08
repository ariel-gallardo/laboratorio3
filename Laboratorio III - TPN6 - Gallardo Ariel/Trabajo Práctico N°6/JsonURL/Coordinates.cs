using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_N_6.JsonURL
{
    public class Coordinates
    {
        public string latitude { get; set; }
        public string longitude { get; set; }

        public Coordinates(string latitude, string longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}
