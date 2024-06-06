using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Queue miQ = new Queue(); // FIFO

        // Adicionamos objetos
        miQ.Enqueue("Manzana");
        miQ.Enqueue("Fresa");
        miQ.Enqueue("Pera");

        // iteramos
        foreach (string fruta in miQ)
            Console.WriteLine("->{0}",fruta);

        Console.WriteLine("-----");

        // obtenemos objeto
        Console.WriteLine("Dequeue {0}", miQ.Dequeue());
        Console.WriteLine("Dequeue {0}", miQ.Dequeue());

        foreach (string fruta in miQ)
            Console.WriteLine("Después de dequeue->{0}", fruta);

        Console.WriteLine("-----");

        // adicionamos objetos
        miQ.Enqueue("Limon");
        miQ.Enqueue("Mango");
        miQ.Enqueue("Ciruela");

        // Observamos el objeto
        Console.WriteLine("Peek {0}", miQ.Peek());

        foreach (string fruta in miQ)
            Console.WriteLine("Después de peek ->{0}", fruta);

        Console.WriteLine("-----");

        // conteo de objetos
        Console.WriteLine(miQ.Count);

        Console.WriteLine("-----");

        // verificar si existe un elemento
        Console.WriteLine(miQ.Contains("Mango"));
        Console.WriteLine(miQ.Contains("Manzana"));

    }
}