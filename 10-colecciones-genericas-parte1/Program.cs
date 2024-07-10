using System;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Colecciones normales");
        Array miAL = new int[5] { 1, 2, 3, 5, 24 };

        Console.WriteLine("Iterar sobre Array");
        foreach (object number in miAL)
        {
            Console.WriteLine((int)number); // Typecast a int
        }

        Console.WriteLine("Colecciones genéricas");
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        foreach (int i in list)
            Console.WriteLine(i);
    }
}
