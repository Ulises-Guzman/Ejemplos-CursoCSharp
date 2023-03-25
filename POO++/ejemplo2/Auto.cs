using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Auto : Vehiculo
    {
        //Constructor
        public Auto()
        {
            Chasis = new Chasis();
        }


        //Propiedades
        public int Anio { get; set; }

        public string Modelo { get; set; }

        public string Color { get; set; }


        //Composicion
        public Chasis Chasis { get; }


        //Asociacion
        public Motor Motor { get; set; }



    }
}
