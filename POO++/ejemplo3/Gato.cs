using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Gato : AnimalDomestico
    {
        
        //Metodo Sobrescrito desde la Clase Animal
        public override string Comunicarse()
        {
            return "El Gato hace: miau...miau...";
        }
    }
}
