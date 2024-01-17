using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema5
{
    public static void Solve()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] vector = new int[n];

        Console.WriteLine("Introduceti elementele vectorului:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Introduceti valoarea e: ");
        int e = int.Parse(Console.ReadLine());

        Console.Write("Introduceti pozitia k: ");
        int k = int.Parse(Console.ReadLine());

        InsertElementAtPosition(vector, e, k);

        Console.WriteLine("Vectorul dupa inserare:");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
        }
    }

    public static void InsertElementAtPosition(int[] vector, int e, int k)
    {
        Array.Resize(ref vector, vector.Length + 1);

        for (int i = vector.Length - 1; i > k; i--)
        {
            vector[i] = vector[i - 1];
        }

        vector[k] = e;
    }

}

