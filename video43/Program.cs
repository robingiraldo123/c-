using System;

namespace video43
{
    class Program
    {
        static void Main(string[] args)
        {
            caballo Babieca = newcaballo("Babieca");
            Humano Juan = new Humano("Juan");
            Gorila Copito = newgorila("Copito");
            Juan.getNombre();
            Babieca.getNombre();
            Copito.getNombre();
        }
    }
    Class Mamifero
    {
        public Mamiferos(string Nombre)
    {
        nombreservivo = nombre;
    }
        private void respirar()
    {
        Console.WriteLine("soy capaz de respirar");
    }
         public void cuidarcrias()
          {
        console.WriteLine("cuido mis crias hasta que se valgan por si solas")
        }
           public void getNombre
        {
        console.WriteLine("el nombre del ser vivo es:"+nombreservivo);
      }
       private string nombreServivo;
   }
class caballo : Mamiferos
{
    public caballo(string nombreCaballo) : base(nombreCaballo)
    {

    }
    public void galopar()
    {
        console.WriteLine("soy capaz de galopar");
    }
}
class humano : Mamiferos
{
    public humano(string nombreHumano) : base(nombreHumano)
    {

    }
    public void pensar()
    {
        Console.WriteLine("soy capaz de pensar¿?")
        }
}
class Gorila : Mamiferos
{
    public Gorila(string nombreGorila) : base(nombreGorila)
    {

    }
    public void pensar()
    {
        console.WriteLine("pensamiento institivo avanzado");
    }
}
class Gorila : Mamiferos
{
    public Gorila(string nombreGorila) : base(nombreGorila)
    {

    }
    public void pensar()
    {
        console.WriteLine("pensamiento institivo avanzado");
    }
}

        

}
