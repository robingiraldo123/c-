using System;

namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            coche coche1 = new coche();
            coche coche2 = new coche();
            Console.writeLine(coche1.getRuedas());

            Console.writeLine(coche2.getRuedas());
            coche coche3 = new coche();
            console.writeLine(coche3.getRuedas());

        }
    }
    class coche
    {
        public coche()
        {
            ruedas 4;
            largo 2300.5;
            ancho 0.800;
        }
        public string getInfocoche(double largo coche, double ancho coche)
        {
            return "Informacion del coche:/n" + "Ruedas:"ruedas + " + largo + " + largo "Ancho";
        }
        public void SetExtras(bool paramclimatizador, string Paramtapiceria,)
        {
            climatizador = paramclimatizador

           tapiceria = Paramtapiceria
        }
        public string getExtras()
        {
            return "Extras del coche;\"+ "Ruedas: "ruedas + " + largo + " + largo "Ancho"; 
        }
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;
    }
}
