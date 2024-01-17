using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema6
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

        Console.Write("Introduceti pozitia k: ");
        int k = int.Parse(Console.ReadLine());

        DeleteElementAtPosition(vector, k);

        Console.WriteLine("Vectorul dupa stergere:");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
        }
    }

    public static void DeleteElementAtPosition(int[] vector, int k)
    {
        for (int i = k; i < vector.Length - 1; i++)
        {
            vector[i] = vector[i + 1];
        }

        Array.Resize(ref vector, vector.Length - 1);
    }

}

