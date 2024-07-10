using System.ComponentModel.DataAnnotations.Schema;

namespace _13_stack_queue_genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<CPunto> puntos = new Stack<CPunto>();
            puntos.Push(new CPunto(3, 4));
            puntos.Push(new CPunto(5, 7));
            puntos.Push(new CPunto(9, 11));
            puntos.Push(new CPunto(1, 4));

            Console.WriteLine("Stack Pila");

            foreach (CPunto p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("----------");

            Console.WriteLine("Peek {0}", puntos.Peek());

            Console.WriteLine("----------");

            Console.WriteLine("Pop {0}", puntos.Pop());
            Console.WriteLine("Pop {0}", puntos.Pop());
            foreach (CPunto p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("Queue Cola");

            Queue<CPunto> puntosCola = new Queue<CPunto>();
            Console.WriteLine("Enqueue");
            puntosCola.Enqueue(new CPunto(3, 7));
            puntosCola.Enqueue(new CPunto(7, 9));
            puntosCola.Enqueue(new CPunto(11, 2));

            foreach (CPunto p in puntosCola)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("----------");

            Console.WriteLine("Peek {0}", puntosCola.Peek());

            Console.WriteLine("Dequeue {0}", puntosCola.Dequeue());
            Console.WriteLine("Dequeue {0}", puntosCola.Dequeue());
            Console.WriteLine("Dequeue {0}", puntosCola.Dequeue());

            foreach (CPunto p in puntosCola)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("----------");

        }
    }
}