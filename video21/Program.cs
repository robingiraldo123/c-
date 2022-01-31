using System;

namespace UsodOWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.next(0, 100);
            int mi numero = 101;
            int intentos = 0;

            Console.WriteLine("Introduce un numero entre 0 y 100");
            do
            {
                intentos++;
                minumero = int.parse(Console.readLine());
                if (minumero > aleatorio) Console.writeLine("el n° es mas bajo")
                if (minumero < aleatorio) Console.writeLine("el n° es mas alto")
            }
            while (aleatorio != minumero)
            Console.writeLine($"correcto!Has necesitado{intentos}intentos");
        }
    }
}
