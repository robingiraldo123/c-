using System;

namespace UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int mi numero = 101;
            int intentos = 0;

            Console.WriteLine("Introduce un numero entre 0 y 100");
            while (aleatorio != minumero)
            {
                intentos++;
                minumero = int.parse(Console.readLine());
                if (minumero > aleatorio) Console.writeLine("el n° es mas bajo")
                if (minumero < aleatorio) Console.writeLine("el n° es mas alto")
            }
            Console.WriteLine($"Correcto!has necesitado {intentos}intentos")
        }
    }
}
