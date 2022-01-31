using System;
using System.Collections.Generic;

namespace Video66
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            //Rellenando o agregando elementos al Stack

            foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Push(numero);
            }

            //Recorriendo el Stack

            Console.WriteLine("Recorriendo el Stack");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //Eliminando elementos del Stack


            Console.WriteLine("Eliminando elementos");

            numeros.Pop();

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            ///Dictionary
            ///
            Console.WriteLine("Empieza Dictionary");
            

            Dictionary<string, int> edades = new Dictionary<string, int>();

            //Rellenar el diccionario

            edades.Add("Juan", 18);
            edades.Add("Pedro", 25);
            edades.Add("Caleb", 10);

            edades["Maria"] = 25;
            edades["Antonio"] = 34;

            //Recorrer el diccionario

            foreach (KeyValuePair<string, int> persona in edades)
            {
                Console.WriteLine("Nombre: {0} Edad: {1}", persona.Key, persona.Value);
            }
        }
    }
}
