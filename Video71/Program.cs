using System;
using System.Text.RegularExpressions;

namespace Video71
{
    class Program
    {
        static void Main(string[] args)
        {

            string txt = "cursos@pildorasinformaticas.es";

            string re1 = ".*?";
            string re2 = "(@)";
            string re3 = ".*?";
            string re4 = "(\\.)";

            Regex r = new Regex(re1 + re2 + re3 + re4, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m = r.Match(txt);
            if (m.Success)
            {
                Console.WriteLine("Email correcto");
            }
            else
            {
                Console.WriteLine("Email incorrecto");
            }

            

            string frase = "Mi web es http://pildorasinformaticas.es";

            string patron = "https?://(www.)?pildorasinformaticas.es";

            Regex miRegex = new Regex(patron);

            MatchCollection elmatch = miRegex.Matches(frase);

            if (elmatch.Count > 0) Console.WriteLine("Se ha encontrado web");
            else Console.WriteLine("No se ha encontrado web");
        }
    }
}
