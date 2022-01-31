using System;
{
    class Program
  {
    static void Main(string[] args)
    {
        console.writeLine("introduce el primer numero");
        int num1 = int.parse(console.ReadLine());
        console.writeLine("introduce el segundo numero");
        int num2 = int.parse(console.ReadLine());
        console.writeLine("el resultado es" + (num1 + num2));


    }
   }
}
