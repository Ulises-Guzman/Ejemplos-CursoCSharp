using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }


        //Sobrescribo el Metodo To String
        public override string ToString()
        {
            return "El Animal Domestico es: " + Nombre;
        }
    }

}
