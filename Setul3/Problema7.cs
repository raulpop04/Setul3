using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema7
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

        ReverseArray(vector);

        Console.WriteLine("Vectorul inversat:");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
        }
    }

    public static void ReverseArray(int[] vector)
    {
        int i = 0;
        int j = vector.Length - 1;

        while (i < j)
        {
            int temp = vector[i];
            vector[i] = vector[j];
            vector[j] = temp;

            i++;
            j--;
        }
    }

}

