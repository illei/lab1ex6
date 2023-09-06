using System;

namespace lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
            descrescatoare.*/
            int[] tabel = new int[3];
            for (int i = 0; i < 3; i++)
            {
                tabel[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(tabel);
            string myString = String.Join(",", tabel);
            Console.WriteLine(myString);

        }
    }
}
