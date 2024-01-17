using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema9
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

        Console.Write("Introduceti numarul de pozitii k pentru rotirea spre stanga: ");
        int k = int.Parse(Console.ReadLine());

        RotateArrayLeftK(vector, k);

        Console.WriteLine($"Vectorul dupa rotirea spre stanga cu {k} pozitii:");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
        }
    }

    public static void RotateArrayLeftK(int[] vector, int k)
    {
        k = k % vector.Length;

        for (int i = 0; i < k; i++)
        {
            RotateArrayLeft(vector);
        }
    }

    public static void RotateArrayLeft(int[] vector)
    {
        int temp = vector[0];

        for (int i = 1; i < vector.Length; i++)
        {
            vector[i - 1] = vector[i];
        }

        vector[vector.Length - 1] = temp;
    }
}

