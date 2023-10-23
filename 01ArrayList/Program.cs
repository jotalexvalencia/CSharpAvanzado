using System;
using System.Collections;

namespace _01ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Colecciones adentro de System.Collection
            // ArrayList
            // BitArray
            // Hashtable (k,v)
            // Queue
            // SortedList (k,v) k,[]
            // Stack

            ArrayList palabras = new ArrayList();
            int n = 0;
            int r = 0;

            // Podemos adicionar con rango
            palabras.AddRange(new string[] { "hola", "como", "estan?" });// Se pasa una coleccion como parametro

            Console.WriteLine("Cantidad de elementos en el ArrayList es {0}", palabras.Count);

            // Recorremos con ciclo for
            for(n=0; n<palabras.Count; n++)
                Console.WriteLine(" {0}", palabras[n]);

            Console.WriteLine();
            Console.WriteLine("- - - -");
        }
    }
}
