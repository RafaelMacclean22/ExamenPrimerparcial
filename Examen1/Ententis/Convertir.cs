using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Ententis
{
    class Convertir
    {
        public static float ConvertirdeKelvinaCelcius (float Kelvin)
        {
            return (Kelvin - 273.15f);
        }

        public static float ConvertirdemillasaKm(float Millas)
        {
            return (Millas * 3.6f);
        }
    }
}
