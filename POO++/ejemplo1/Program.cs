using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona > Lider > Developer > Tester

            //Persona p1 = new Persona();
            //p1.Apellido = "";

            Developer d1 = new Developer();
            d1.Apellido = "Guzman";

            Lider l1 = new Lider();
            //l1.Nombre = "Ulises";

            //Lamo al Metodo "HacerAlgo" de la Clase Lider
            Lider.HacerAlgo();


            Tester t1 = new Tester();
            t1.Dni = 12345678;

            //HACIENDO MODIFICACIONES PARA PRACTICA DE GITHUB
        }
    }
}
