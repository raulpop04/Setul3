using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema15
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

        RemoveDuplicates(vector);

        Console.WriteLine("Vectorul dupa eliminarea duplicatelor:");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
        }
    }

    public static void RemoveDuplicates(int[] vector)
    {
        int newSize = 1;

        for (int i = 1; i < vector.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < newSize; j++)
            {
                if (vector[i] == vector[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                vector[newSize] = vector[i];
                newSize++;
            }
        }

        Array.Resize(ref vector, newSize);
    }

}

