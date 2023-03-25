using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Canario : AnimalDomestico, Flyable
    {
        public string Volar()
        {
            return "Vuela como un Canario...";
        }
    }
}
