using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //array implicito
            // var datos =new[] { "Juan", "Diaz", "15"};
            var valores = new[] { 15, 28, 35, 75.5, 30.30 };// todo a double 
                                                            //array de objetos 

            Empleados[] array empleados = newEmpleados[2];
            arrayEmpleados[0] = newEmpleados("sara", 37);
            arrayEmpleados[1] = Ana;

            var personas = new[]
            {
                 new{Nombre="Juan",Edad=19},
                 new{Nombre="Maria",Edad=49},
                 new{Nombre="Diana",edad=35},
             };
            int contador = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(valores[contador]);
                contador++;

            }
        }
    }
}
