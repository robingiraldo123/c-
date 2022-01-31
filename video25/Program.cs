using System;

namespace UsoChecked

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el n° del mes");
            int NumeroMes = int.parse(console.readLine());
            try
            {
                Console.WriteLine("Nombre del mes (n°del mes)");
            }
            catch (exception e)
            {
                Console.WriteLine("Mensaje de la excepcion" +.Message);
            }
       
        }
    }
}
