using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AnimalDomestico a1 = new AnimalDomestico();
            //a1.Nombre = "Firulais";

            //Llamo al Metodo base ToString Sobrescrito
            //Console.WriteLine(a1.ToString());

            //Llamo al Metodo Base Comunicarse
            //Console.WriteLine(a1.Comunicarse());

            //Creo los objetos
            Gato g1 = new Gato();
            g1.Nombre = "Michi";

            Perro p1 = new Perro();
            p1.Nombre = "Firulais";


            //Genero una Lista d tipo objeto Animal
            List<Animal> animales = new List<Animal>();

            animales.Add(g1);
            animales.Add(p1);
            animales.Add(new Aguila());
            animales.Add(new Canario());
            animales.Add(new Pez());
            animales.Add(new Tigre());
            animales.Add(new Gato());

            //Genero un Lista de tipo Interface "Flyable"
            //De estamanera segmento objetos
            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Aguila());
            listaVoladores.Add(new Canario());



            //Explicacion de Asignacion de variables a un obj tipo Animal
            //Asignacion y Casteo

            //Animal a1 = g1;

            //Aqui el compilador entiende que no sabe si la variable del tipo Animal es una variable de tipo Gato
            //y marca error
            //Gato g8 = a1;

            //Entonces es posible Castear. Casteo Explicito.
            //Gato g8 = (Gato)a1;

            ////Es posible asignar valores a g8 utilizando los Metodos Sobrecargados
            //g8.Nombre = "Michifuu";

            ////Muestro el la propiedad Nombre
            //Console.WriteLine(g8.Nombre);


            ////Llamo al Metodo Sobrescrito en la clase Gato
            //Console.WriteLine(g1.Comunicarse());

            ////Llamo al Metodo Sobrescrito en la clase Perro
            //Console.WriteLine(p1.Comunicarse());


            //Recorro la lista y llamo al Metodo Comunicarse
            //Aqui es Posible observar el POLIMORFISMO
            //foreach (Animal item in animales)
            //{
            //    Console.WriteLine(item.Comunicarse());
            //}   


            Console.ReadKey();
        }
    }
}
