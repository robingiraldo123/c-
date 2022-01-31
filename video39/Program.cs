using System;

namespace video39
{
    class Program
    {
        static void Main(string[] args)
        {
            //array implicito
            // var datos =new[] { "Juan", "Diaz", "15"};
            var valores = new[] { 15, 28, 35, 75.5, 30.30 };// todo a double 
                                                            //array de objetos 
            Empleados Ana = new Empleados("Ana"27);
            Empleados[] array empleados = newEmpleados[3];
            arrayEmpleados[0] = newEmpleados("sara", 37);
            arrayEmpleados[1] = Ana;

            var personas = new[]
            {
                new{Nombre="Juan",Edad=19},
                 new{Nombre="Maria",Edad=49},
                 new{Nombre="Diana",edad=35},
            }
             /*for(int i=0;i<arrayempleados.lenght;i++)
             {
                 arrayEmpleados[0].nombre="Leo Messi"
               Console.WriteLine(arrayEmpleados[i].nombre);
              /*


              foreach(empleados  variable in arrayEmpleados)
              {
              Console.WriteLine(variable.getInfo());
              }
     }
             class Empleados
             {
              public Empleados(string)

             This.nombre=nombre;
              this.edad=edad;
              }
             public string getInfo()
              {
           return "nombre del empleado"

          }
             private  string nombre;
            private int edad;
}
