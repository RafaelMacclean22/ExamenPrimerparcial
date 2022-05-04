using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Examen1.Ententis
{
    class City
    {
        public class Coord
        {
            public string lon  {get; set;}
            public string la { get; set; }

        }

        public class Main
        {
            public string Temp { get; set; }
            public string Temp_Max { get; set; }
            public string Temp_Min { get; set; }
            public string pressure { get; set; }
            public string humeduity { get; set; }

        }

        public class Sys      
        {
            public int sunrise { get; set; }
            public int  Sunset { get; set; }
        }

        public class Weather
        {
            public string main { get; set; }
            public string descrepcion { get; set; }
            public string Icon { get; set; }
        }

        public class Wind
        {
            public string speed { get; set; }
        }

        public class root
        {
            public Coord coord { get; set; }
            public List<Weather> weather { get; set; }
            public Main main { get; set; }
            public Wind wind { get; set; }
            public Sys sys { get; set; }
        }

    }
}
