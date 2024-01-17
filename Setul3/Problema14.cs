using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema14
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

        MoveZerosToEnd(vector);

        Console.WriteLine("Vectorul dupa mutarea zerourilor la sfarsit:");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
        }
    }

    public static void MoveZerosToEnd(int[] vector)
    {
        int index = 0;

        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] != 0)
            {
                int temp = vector[i];
                vector[i] = vector[index];
                vector[index] = temp;
                index++;
            }
        }
    }

}

