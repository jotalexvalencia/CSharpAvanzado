using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        BitArray miArreglo = new BitArray(new byte[] { 1, 2, 4, 8, 16 });

        // quantity of elements, 5 bytes * 8 = 40 bits
        Console.WriteLine(miArreglo.Count);
        MuestraArreglo(miArreglo);

        Console.WriteLine("---");

        // get a bit in a position
        Console.WriteLine(miArreglo.Get(3));

        // push a bit in a position
        miArreglo.Set(3, true);// index, value
        MuestraArreglo(miArreglo);
        Console.WriteLine(miArreglo.Get(3));
        Console.WriteLine("---");

        // clone the BitArray
        BitArray arreglo2 = (BitArray)miArreglo.Clone();// typecast because return an object
        MuestraArreglo(arreglo2, "Arreglo2");

        // invert the BitArray arreglo2
        arreglo2.Not();
        MuestraArreglo(arreglo2, "Arreglo2 with NOT");

        Console.WriteLine("---");

        // create other bitArray
        BitArray arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 15 });
        MuestraArreglo(arreglo3, "arreglo3");
        Console.WriteLine("---");

        // do OR between arreglo3 and miArreglo
        arreglo3.Or(miArreglo);// with OR arreglo3 change, but miArreglo not change
        MuestraArreglo(miArreglo, "miArreglo OR");
        MuestraArreglo(arreglo3, "arreglo3 OR");
        Console.WriteLine("---");

        // do AND between arreglo3 and miArreglo with AND  arreglo 3 change
        MuestraArreglo(miArreglo, "miArreglo");
        MuestraArreglo(arreglo3, "arreglo3");
        Console.WriteLine("---"); 

        arreglo3.And(miArreglo);
        MuestraArreglo(arreglo3, "arreglo3 AND");
        Console.WriteLine("---");

        // do XOR between arreglo3 and miArreglo
        arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 21 });
        MuestraArreglo(miArreglo, "miArreglo");
        MuestraArreglo(arreglo3, "arreglo3");
        Console.WriteLine("---"); 
        arreglo3.Xor(miArreglo); // arreglo3 change
        MuestraArreglo(arreglo3, "arreglo3 XOR");
        Console.WriteLine("---");

    }

    public static void MuestraArreglo(BitArray pArreglo, string pNombre = "")
    {
        int c = 0;
        Console.WriteLine("{0}\t", pNombre);

        foreach (bool b in pArreglo)
        {
            c++;
            if(b) Console.Write("1");
            else Console.Write("0");
            if(c%8 == 0) Console.Write(",");

        }
        Console.WriteLine();
    }
}