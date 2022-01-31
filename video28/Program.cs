using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo mi circulo;
            mi circulo = new circulo();
            Console.WriteLine(micirculo.calculoArea(5));
            Circulo miCirculo2 = new circulo();
            Console.WriteLine(miCirculo2.calculoArea(9));
            micirculo.pi = 50.45;
            Console.WriteLine(miCirculo2.calculoArea(5));
        }
    }
    class circulo
    {
        double pi = 3.1416
        double calculoArea(int radio);
        {return pi= radio* radio;
        }
     }  

}
