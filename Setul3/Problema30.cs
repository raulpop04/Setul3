using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema30
{
    public static void Solve()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] E = new int[n];
        int[] W = new int[n];

        Console.WriteLine("Introduceti elementele vectorului E:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"E[{i}]: ");
            E[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Introduceti elementele vectorului W (ponderi):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"W[{i}] (ponderea pentru E[{i}]): ");
            W[i] = int.Parse(Console.ReadLine());
        }

        SortareBicriteriala(E, W);

        Console.WriteLine("Vectorii sortati:");
        AfiseazaVectori(E, W);
    }

    public static void SortareBicriteriala(int[] E, int[] W)
    {
        List<Tuple<int, int>> perechi = new List<Tuple<int, int>>();

        for (int i = 0; i < E.Length; i++)
        {
            perechi.Add(new Tuple<int, int>(E[i], W[i]));
        }

        perechi.Sort((x, y) =>
        {
            int comparatieE = x.Item1.CompareTo(y.Item1);
            if (comparatieE != 0)
            {
                return comparatieE;
            }
            return -x.Item2.CompareTo(y.Item2);
        });

        for (int i = 0; i < E.Length; i++)
        {
            E[i] = perechi[i].Item1;
            W[i] = perechi[i].Item2;
        }
    }

    public static void AfiseazaVectori(int[] E, int[] W)
    {
        for (int i = 0; i < E.Length; i++)
        {
            Console.WriteLine($"E[{i}] = {E[i]}, W[{i}] = {W[i]}");
        }
    }

}

