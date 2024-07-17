using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_sortedSetGenerico
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<CPunto> puntos = new SortedSet<CPunto>();
            puntos.Add(new CPunto(3, 7));
            puntos.Add(new CPunto(8, 11));
            puntos.Add(new CPunto(2, 6));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("-----------");

            puntos.Add(new CPunto(1, 15));
            puntos.Add(new CPunto(1, 2));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("----Obervable coleccion-------");

            ObservableCollection<CPunto> puntos2 = new ObservableCollection<CPunto>()
            { new CPunto(4,55), new CPunto(17,22) };

            // Adicionamos el handler
            puntos2.CollectionChanged += puntos_CollectionChanged;

            puntos2.Add(new CPunto(2, 3));

            CPunto miPunto = new CPunto(5, 5);

            puntos2.Add(miPunto);

            puntos2.Remove(miPunto);

        }

        // Este es el handler que se invoca cuando cambia la colección
        static void puntos_CollectionChanged(object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // Vemos el tipo de evento que ocurrió
            Console.WriteLine("El evento es {0}", e.Action);

            // Si la acción es adicionar
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Elementos nuevos");
                foreach (CPunto p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());

                }

            }

            // Si la accion fue remover
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Elementos afectados por el cambio");

                foreach (CPunto p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());

                }

                Console.WriteLine();
            }

        }
    }
}