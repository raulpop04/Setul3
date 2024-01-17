using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema2
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

        Console.Write("Introduceti valoarea k: ");
        int k = int.Parse(Console.ReadLine());

        int pozitie = -1;
        for (int i = 0; i < n; i++)
        {
            if (vector[i] == k)
            {
                pozitie = i;
                break;
            }
        }

        Console.WriteLine($"Prima pozitie in care apare {k} este: {pozitie}");
    }
}

