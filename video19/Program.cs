using System;

namespace UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.next(0, 100);
            Console.writeLine(numeroAleatorio);


        }
    }
}
