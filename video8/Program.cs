using System;

namespace video8
{
    class Program
    {
        static void Main(string[] args)
        {
            cons double PI = 3.1416;
            console.writeLine("introduce la medida del radio");
            double radio = double.parse(console.readline());
            //double area= radio *radio*PI;
            double area = Math.Pow(radio, 2);
            console.writeLine($"el area del circulo es :{area}");
        }
    }
}
