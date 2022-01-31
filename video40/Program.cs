using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            numeros[0] = 7;

            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;

            procesaDatos(numeros);

            int arrayElementos = LeerDatos();
            console.WriteLine("imprimiendo desde el main");
            foreach (int i in arrayElementos) console.WriteLine("i");

        }
        static void ProcesaDatos(int[] datos)
        {
            foreach (int i in datos)
            {
                Console.WriteLine(i);
            }
        }
        static int[] LeerDatos()
        {
            Console.WriteLine("¿cuanto elementos quieres que tenga el array?")
            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);
            int[] Datos = new int[numElementos];
            for (int i = 0; i < numElementos; i++)
            {
                console.WriteLine($"introduce el dto para la posicion{i}");
                respuesta = Console.ReadLine();
                int datosElemento = int.Parse(respuesta);
                datos[i] = datosElemento;
            }
        }
    }
    
}
