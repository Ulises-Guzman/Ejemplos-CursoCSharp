using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Lider //: Persona "No es posible Heredar ni Instanciar" en el caso de "static class"
    {
        public int Legajo { get; set; }


        //Aqui el Metodo esta ubicado en tipo estatico/static
        public static string HacerAlgo()
        {
            return "Hola como estas...";
        }
    }
}
