using System;

namespace Video67
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion del objeto delegado apuntando a MensajeBienvenida
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            //Utilizacion del delegado para llmar al metodo saludo bienvenida
            ElDelegado("Hola estoy llegado. que tal?");

            ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

            ElDelegado("Hola ya me voy. hasta luego");
        }

        //Definicion del objeto delegado
        delegate void ObjetoDelegado(string msj);

        class MensajeBienvenida
        {
            public static void SaludoBienvenida(string msj)
            {
                Console.WriteLine("Mensaje de Bienvenida: {0}", msj);
            }
        }
        class MensajeDespedida
        {
            public static void SaludoDespedida(string msj)
            {
                Console.WriteLine("Mensaje de Despedida: {0}", msj);
            }
        }
    }
}
