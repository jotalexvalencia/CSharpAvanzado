using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Clase_Generica
{
    // T representa al tipo con el que se trabaja en un momento dado
    class CPunto<T>
    {
        // Creamos variables de tipo T
        private T x;
        private T y;

        public CPunto(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format("X={0}, Y={1}", x, y);
        }
        public void Reset()
        {
            // colocamos el valor de default para el tipo T
            // Numericos 0
            // Referencias null

            x = default(T);
            y = default(T);
        }
        public void EncuentraTipo()
        {
            if (typeof(T) == typeof(int))
            {
                Console.WriteLine("Trabajo como entero");
            }
            else
            {
                Console.WriteLine("Soy de otro tipo");
            }
        }
    }
}
