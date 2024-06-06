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

            // Otra forma de adicionar elementos
            palabras.Add("Bien y tu?");

            // recorremos fon foreach
            foreach(string palabra in palabras)
            {
                Console.Write(" {0}", palabra);
            }

            Console.WriteLine();
            Console.WriteLine("- - - -");

            ArrayList valores = new ArrayList();
            valores.Add(5);
            valores.Add(7);
            valores.Add(4);

            // recorremos con for
            for (n = 0; n< valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            Console.WriteLine("- - - -");

            // vemos si existe un elemento en el arraylist
            Console.WriteLine(valores.Contains(5));
            Console.WriteLine(valores.Contains(17));
            Console.WriteLine("- - - -");

            // insertar en un indice en particular
            valores.Insert(2, 55); // indice, valor a insertar

            for (n = 0;n< valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            Console.WriteLine("- - - -");

            //removemos
            valores.Remove(55);
            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            Console.WriteLine("- - - -");

            //removemos en una posición
            valores.RemoveAt(0);
            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            Console.WriteLine("- - - -");
        }
    }
}
