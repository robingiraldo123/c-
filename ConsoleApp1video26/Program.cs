using System;

namespace EjemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            system.IO.streamreader archivo = null;

            try
            {
                string linea;
                int contador = 0;
                string path = @"C:\Users\Robinson.Orrego\Documents\c#  pildoras informaticas"
             archivo = new System.IO.StreamReader(path);
                while ((linea = archivo.readLine()) != null) ;
                {
                    console.writelines(linea);
                    contador++;
                }

            }
            catch (Exception ex)
            {
                console.writeline("Error con la lectura del archivo");
            }
            finally
            {
                if (archivo != null) archivo.close();
                Console.writeline("conexion con el fichero de cerrada");
            }
        }
    }
}
