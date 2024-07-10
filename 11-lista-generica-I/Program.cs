using System.Collections.Generic;
namespace _11_lista_generica_I
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();
            int n = 0;
            int r = 0;

            valores.Add(7);
            valores.Add(5);
            valores.Add(4);
            valores.Add(3);
            valores.Add(8);
            valores.Add(9);

            // recorrer con ciclo for
            for (n = 0; n < valores.Count; n++)
            {
                // No hay necesidad de type cast
                r = valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("_____");

            // vemos si contiene determinado elemento
            Console.WriteLine(valores.Contains<int>(5));
            Console.WriteLine(valores.Contains<int>(17));
            Console.WriteLine("_____");

            // obtenemos el índice de un elemento
            Console.WriteLine("índice del 4: {0}",valores.IndexOf(4));
            Console.WriteLine("índice del 17: {0} si no existe retorna -1",valores.IndexOf(17));
            Console.WriteLine("_____");

            // insertamos elemento en un índice
            Console.WriteLine("Inertar en el índice 2 el valor 55");
            valores.Insert(2, 55);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("_____");

            Console.WriteLine("Eliminar el elemento del índice 3");
            valores.RemoveAt(3);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("_____");

            Console.WriteLine("eliminar la primera ocurrencia de un valor en este caso 8");
            valores.Remove(8);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("_____");

            Console.WriteLine("Reverse->la lista se coloca en sentido contrario");
            valores.Reverse();

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("_____");
            Console.WriteLine("Sort->Ordenar la lista");
            valores.Sort();

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("_____");
            Console.WriteLine("Creamos lista para clase CPunto");

            List<CPunto> listaPuntos = new List<CPunto>();

            listaPuntos.Add(new CPunto(5, 3));
            listaPuntos.Add(new CPunto(7, 8));
            listaPuntos.Add(new CPunto(12,5));
            listaPuntos.Add(new CPunto(6, 2));

            foreach (CPunto punto in listaPuntos)
                Console.WriteLine(punto);

            Console.WriteLine("Adición Explícita");
            List<CPunto> puntos = new List<CPunto>()
            {
                new CPunto(2,3),
                new CPunto(5,23),
                new CPunto (7,9),
            };

            foreach (CPunto p in puntos)
                Console.WriteLine(p);

            Console.WriteLine("Add->adicionamos un punto");
            puntos.Add (new CPunto(45,90));

            foreach (CPunto p in puntos)
                Console.WriteLine(p);

            Console.WriteLine("Insert -> insertamos un punto");
            puntos.Insert(2, new CPunto(100, 150));

            foreach (CPunto p in puntos)
                Console.WriteLine(p);

            Console.WriteLine("Copiamos de lista a arreglo");
            CPunto[] arregloPuntos = puntos.ToArray();
            for (int i = 0; i < arregloPuntos.Length; i++)
            {
                Console.WriteLine(arregloPuntos[i]);
            }
        }
    }
}