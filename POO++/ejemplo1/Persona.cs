using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal abstract class Persona
    {
        private string apellido;
        private string nombre;
        private long dni;
        

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public long Dni { get; set; }

    }
}
