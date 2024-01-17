using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Problema12
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

        SelectionSort(vector);

        Console.WriteLine("Vectorul sortat folosind Selection Sort:");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
        }
    }

    public static void SelectionSort(int[] vector)
    {
        for (int i = 0; i < vector.Length - 1; i++)
        {
            int indexMinim = i;

            for (int j = i + 1; j < vector.Length; j++)
            {
                if (vector[j] < vector[indexMinim])
                {
                    indexMinim = j;
                }
            }

            if (indexMinim != i)
            {
                int temp = vector[i];
                vector[i] = vector[indexMinim];
                vector[indexMinim] = temp;
            }
        }
    }

}
