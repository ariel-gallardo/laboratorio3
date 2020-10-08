using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_N_6.JsonURL
{
    public class Location
    {
        public Street street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public object postcode { get; set; }
        public Coordinates coordinates { get; set; }
        public Timezone timezone { get; set; }

        public Location(Street street, string city, string state, string country, object postcode, Coordinates coordinates, Timezone timezone)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.country = country;
            this.postcode = postcode;
            this.coordinates = coordinates;
            this.timezone = timezone;
        }
    }
}
