using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo > Auto > AutoDeportivo > AutoCalle
            //         > Camioneta
            //         > Moto

            //Vehiculo v1 = new Vehiculo();

            //Auto a1 = new Auto();
            //a1.Motor = 1.8F;
            //a1.TipoMotor = "Nafta";

            //Camioneta c1 = new Camioneta();
            //c1.Modelo = "LTZ";
            //c1.TipoMotor = "Diesel";
            //c1.Traccion = "4x4";
            //c1.Color = "Gris";

            //Camioneta c2 = new Camioneta();
            //c2.Color = "Azul";

            //Camioneta c3 = new Camioneta();
            //c3.Color = "Blanco";

            ////Aqui Creo la Lista tipo Ojeto Camioneta
            //List<Camioneta> listaCamionetas = new List<Camioneta>();

            ////Asignar variables de tipo ojeto
            //listaCamionetas.Add(c1);
            //listaCamionetas.Add(c2);
            //listaCamionetas.Add(c3);

            ////Mostrar la lista
            ////Cuneto la lista
            //Console.WriteLine("La Cantidad de Camionetas es: " + listaCamionetas.Count);

            ////Muestro un elemento determinado de la lista
            //Console.WriteLine("El color de la segunda camioneta es: " + listaCamionetas[1].Color);

            ////Remover un elemento
            ////listaCamionetas.Remove(c3);

            ////Recorrer la Lista Completa
            //foreach (Camioneta item in listaCamionetas)
            //{
            //    Console.WriteLine("El color de cada camioneta es: " + item.Color);
            //}


            //Creo el objeto Auto y luego por Asociacion de Tipo Agregacion le agrego el Motor
            Auto a1 = new Auto();

            //Aqui al Auto le Agrego un Motor a traves de la Propiedad Agregada en la Clase Auto
            a1.Motor = new Motor();

            Console.ReadKey();


        }
    }
}
