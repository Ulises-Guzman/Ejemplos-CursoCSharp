using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Perro : AnimalDomestico
    {
        public override string Comunicarse()
        {
            return "El Perro hace: Guau..Guau...";
        }
    }
}
