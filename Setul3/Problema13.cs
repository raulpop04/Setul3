using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema13
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

        InsertionSort(vector);

        Console.WriteLine("Vectorul sortat folosind Insertion Sort:");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
        }
    }

    public static void InsertionSort(int[] vector)
    {
        for (int i = 1; i < vector.Length; i++)
        {
            int current = vector[i];
            int j = i - 1;

            while (j >= 0 && vector[j] > current)
            {
                vector[j + 1] = vector[j];
                j--;
            }

            vector[j + 1] = current;
        }
    }

}

