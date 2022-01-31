using System;
using System.Text.RegularExpressions;

namespace Video70
{
    class Program
    {
        static void Main(string[] args)
        {
            //Busca numeros con codigo +34 mediante expresiones regulares
            string frase = "Mi nombre es Juan y mi No de Telefono es (+34)123-45-67 y mi codigo postal es 29697";
            string patron = @"[\+34]";

            Regex miRegex = new Regex(patron);

            MatchCollection elmatch = miRegex.Matches(frase);

            if (elmatch.Count > 0) Console.WriteLine("Se han encontrado Numeros de España");
            else Console.WriteLine("No se ha encontrado No se han encontrado numeros de España");
        }
    }
}
