using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Problemas_Clases_Genericas
{
    class COperaciones<T>
    {
        public T Suma(T a, T b)
        {
            dynamic da = a, db = b;
            return da + db;
        }
        public T Resta(T a, T b)
        {
            dynamic da = a, db = b;
            return da - db;
        }
        public T Div(T a, T b)
        {
            dynamic da = a, db = b;
            return da / db;
        }
        public T Multi(T a, T b)
        {
            dynamic da = a, db = b;
            return da * db;
        }
    }
}
