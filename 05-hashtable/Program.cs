using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable miTabla = new Hashtable();

        // Adicionamos elementos
        miTabla.Add(123, "Hola");
        miTabla.Add(234, "Saludos");
        miTabla.Add(45, "Adios");
        miTabla.Add(567, "C#");
        miTabla.Add(12763, "Programacion");

        // mostramos los elementos
        foreach (DictionaryEntry elemento in miTabla)
        {
            Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
        }

        // Intentamos colocar un elemento con la llave repetida
        // miTabla.Add(123, "Otro mas");

        Console.WriteLine("---");

        // cantidad de elementos
        Console.WriteLine(miTabla.Count);

        Console.WriteLine("---");

        // obtenemos el elemntos de determinada llave
        Console.WriteLine(miTabla[567]);
        Console.WriteLine(miTabla[445]);

        Console.WriteLine("---");

        // colocar un elemento en una llave
        miTabla[45] = "Avanzado"; // cambia el valor de la llave 45
        miTabla[300] = "Colecciones"; // Esto también adiciona porque no existe

        foreach (DictionaryEntry elemento in miTabla)
        {
            Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
        }

        // verificamos si hay un elemento
        Console.WriteLine(miTabla.Contains(567));
        Console.WriteLine(miTabla.Contains(335));

        Console.WriteLine("---");

        // eliminar un elemento
        miTabla.Remove(234);

        foreach (DictionaryEntry elemento in miTabla)
        {
            Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
        }

        Console.WriteLine("---");

        foreach (int llave in miTabla.Keys)
        {
            Console.WriteLine(llave);
        }

        Console.WriteLine("---");

        foreach (string valor in miTabla.Values)
        {
            Console.WriteLine(valor);
        }
    }
}