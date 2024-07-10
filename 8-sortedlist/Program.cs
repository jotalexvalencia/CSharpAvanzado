using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        SortedList miSList = new SortedList();

        miSList.Add(754, "Honda");
        miSList.Add(123, "Volvo");
        miSList.Add(587, "Nissan");
        miSList.Add(323, "Fiat");

        foreach (DictionaryEntry elemento in miSList)
        {
            Console.WriteLine("({0} {1})",elemento.Key, elemento.Value);
        }

        Console.WriteLine("Cantidad de elementos: {0}", miSList.Count);

        Console.WriteLine("Verificar si existe una llave con Contains 754 : {0}", miSList.Contains(754));
        Console.WriteLine("Verificar si existe una llave con Contains 755 : {0}", miSList.Contains(755));
        Console.WriteLine("Verificar si existe una llave con ContasinxKey 123 : {0}", miSList.ContainsKey(123));
        Console.WriteLine("Verificar si existe una llave con ContasinxKey 124 : {0}", miSList.ContainsKey(124));
        Console.WriteLine("Verificar si existe un valor con ContainsValue Fiat: {0}", miSList.ContainsValue("Fiat"));
        Console.WriteLine("Verificar si existe un valor con ContainsValue Toyota : {0}", miSList.ContainsValue("Toyota"));

        Console.WriteLine("Obtener la llave en el índice 2: {0}", miSList.GetKey(2));
        Console.WriteLine("Obtener el valor en el índice 2: {0}", miSList.GetByIndex(2));
    }
}