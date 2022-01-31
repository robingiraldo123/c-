﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Video100
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Numeros Pares");

            //List<int> numerosPares = new List<int>();

            //foreach(int i in valoresNumericos)
            //{
            //    if (i % 2 == 0)
            //    {
            //        numerosPares.Add(i);
            //    }
            //}


            //Usando Linq

            IEnumerable<int> numerosPares = from numero in valoresNumericos where numero % 2 == 0 select numero;

            foreach (int i in numerosPares)
            {
                Console.WriteLine(i);
            }
        }
    }
}
