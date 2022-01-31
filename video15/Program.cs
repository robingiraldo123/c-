using System;

namespace practica_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            console.writeLine("vamos a evaluar si puedes conducir");
            console.writeLine("Introduce tu edad porfavor");
            int edad = 32.parse(consol.readLine());
            console.writeLine("¿tienescarnet?");
            string carnet = console.readLine();
            if (edad >= 18 && carnet == "si")
                console.writeLine("puedes conducir vehiculos")
            else
                console.writeLine("no puede conducir vehiculos")
        }

    }
}
