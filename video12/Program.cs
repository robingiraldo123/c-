using System;

namespace practica_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            console.writeLine(suma(7, 5));


        }

        static int suma(int operador1, int operador2) => operador1 + operador2;
        static int suma(int numero1, double numero2) => numero1 + numero2;
        static int suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;
    }
}
