using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Stack miStack = new Stack();
        Console.WriteLine("Push agregar elementos al Stack(Pila)");
        miStack.Push("manzana");
        miStack.Push("pera");
        miStack.Push("ciruela");
        miStack.Push("mango");
        Console.WriteLine("Iterar sobre el Stack(Pila)");
        foreach (string fruta in miStack)
        {
            Console.WriteLine("-> {0}", fruta);
        }
        Console.WriteLine("Pop retira el elemento de la cima y lo devuelve");
        Console.WriteLine(miStack.Pop());
        foreach (string fruta in miStack)
        {
            Console.WriteLine("-> {0}", fruta);
        }
        Console.WriteLine("Peek observa el elemento de la cima de la pila pero no lo retura");
        Console.WriteLine(miStack.Peek());
        foreach (string fruta in miStack)
        {
            Console.WriteLine("-> {0}", fruta);
        }
        Console.WriteLine("Count cantidad de elementos: {0}", miStack.Count);
    }
}