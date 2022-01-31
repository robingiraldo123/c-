using System;

namespace Video69
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Personas P1 = new Personas();
            P1.Nombre = "Juan";
            P1.Edad = 18;

            Personas P2 = new Personas();
            P2.Nombre = "Maria";
            P2.Edad = 18;

            ComparaPersonas comparaedad = (persona1, persona2) => persona1 == persona2;
            Console.WriteLine(comparaedad(P1.Nombre,P2.Nombre));
        }

        //Compara si hay personas con el mimso nombre
        public delegate bool ComparaPersonas(String N1, String N2);
           

        class Personas
        {
            private string nombre;

            private int edad;

            public string Nombre { get => nombre; set => nombre = value; }
            public int Edad { get => edad; set => edad = value; }
        }
    }
}
