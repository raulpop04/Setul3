using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema10
{
    public static void Solve()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] vector = new int[n];

        Console.WriteLine("Introduceti elementele vectorului sortat:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Introduceti elementul k pentru cautare: ");
        int k = int.Parse(Console.ReadLine());

        int pozitie = BinarySearch(vector, k);

        if (pozitie != -1)
        {
            Console.WriteLine($"Elementul {k} se afla pe pozitia {pozitie} in vector.");
        }
        else
        {
            Console.WriteLine($"Elementul {k} nu se gaseste in vector.");
        }
    }

    public static int BinarySearch(int[] vector, int k)
    {
        int stanga = 0;
        int dreapta = vector.Length - 1;

        while (stanga <= dreapta)
        {
            int mijloc = stanga + (dreapta - stanga) / 2;

            if (vector[mijloc] == k)
            {
                return mijloc;
            }
            else if (vector[mijloc] < k)
            {
                stanga = mijloc + 1;
            }
            else
            {
                dreapta = mijloc - 1;
            }
        }

        return -1;
    }

}

