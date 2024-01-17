using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema8
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

        RotateArrayLeft(vector);

        Console.WriteLine("Vectorul dupa rotirea spre stanga:");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
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

