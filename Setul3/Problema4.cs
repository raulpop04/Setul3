using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Problema4
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

        int minim, maxim, aparitiiMinim, aparitiiMaxim;
        FindMinAndMaxWithOccurrences(vector, out minim, out maxim, out aparitiiMinim, out aparitiiMaxim);

        Console.WriteLine($"Cea mai mica valoare: {minim}, Aparitii: {aparitiiMinim}");
        Console.WriteLine($"Cea mai mare valoare: {maxim}, Aparitii: {aparitiiMaxim}");
    }

    public static void FindMinAndMaxWithOccurrences(int[] vector, out int minim, out int maxim, out int aparitiiMinim, out int aparitiiMaxim)
    {
        minim = maxim = vector[0];
        aparitiiMinim = aparitiiMaxim = 1;

        for (int i = 1; i < vector.Length; i++)
        {
            if (vector[i] < minim)
            {
                minim = vector[i];
                aparitiiMinim = 1;
            }
            else if (vector[i] == minim)
            {
                aparitiiMinim++;
            }
            else if (vector[i] > maxim)
            {
                maxim = vector[i];
                aparitiiMaxim = 1;
            }
            else if (vector[i] == maxim)
            {
                aparitiiMaxim++;
            }
        }
    }

}

