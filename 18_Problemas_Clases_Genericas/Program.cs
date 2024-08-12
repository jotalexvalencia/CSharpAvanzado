namespace _18_Problemas_Clases_Genericas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ver la clase COperaciones, no es posible compilar
            // Usamos dynamic para resolverlo, el tipo se checa en ejecución y no en compilación

            //COperaciones<int> miOperacion = new COperaciones<int>();
            COperaciones<string> miOperacion = new COperaciones<string>();

            //Console.WriteLine(miOperacion.Suma(5, 4));
            Console.WriteLine(miOperacion.Suma("hola", " a todos"));

        }
    }
}