using System;

namespace practica_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            console.writeLine("Introduce tu edad");
            int edad = int32.parse(consolereadline());
            if (edad < 18) console.writeLine("eres un niño");
            else if (edad < 30) console.writeLine("eres un joven");
            else if (edad < 60) console.writeLine("eres un maduro");

            else Console.WriteLine("debes cuidarte ya");

        }
    }
}
