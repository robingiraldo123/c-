using System;

namespace practica_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;

            console.writeLine(suma(valor1, valor2));


        }

        nnprivate static double suma(int num1, double num2, double num3 = 0)
        {
            return num1 + num2 + num3;
        }
        static double suma(int num1, double num2)
        {
            return num1 + num2;
        }
    }
}
}
