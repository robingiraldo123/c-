using System;

namespace video22
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.next(0, 100);
            int mi numero = 101;
            int intentos = 0

            Console.writeLine("Introduce un numero entre 0 y 100");
            do
            {
                {
                    try
                    intentos++;
                }
                    catch (FormatException ex)


                   Console.writeLine("No has introducido un valor numerico valido.se toma como n° introducido el 0")
                   mi numero = 0;
                    if (minumero > aleatorio) Console.writeLine("el n° es mas bajo")
                   if (minumero < aleatorio) Console.writeLine("el n° es mas alto")
                            }
                }
            } while (aleatorio != minumero)
            Console.writeLine($"correcto!Has necesitado{intentos}intentos");

            Console.writeLine("A partir de esta linea de codigo el programa continuria");
        }
}
