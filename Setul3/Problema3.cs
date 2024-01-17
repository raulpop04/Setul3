using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema3
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

        int min = vector[0];
        int max = vector[0];
        int pozitieMin = 0;
        int pozitieMax = 0;

        for (int i = 1; i < n; i++)
        {
            if (vector[i] < min)
            {
                min = vector[i];
                pozitieMin = i;
            }
            else if (vector[i] > max)
            {
                max = vector[i];
                pozitieMax = i;
            }
        }

        Console.WriteLine($"Pozitia celui mai mic element ({min}) este: {pozitieMin}");
        Console.WriteLine($"Pozitia celui mai mare element ({max}) este: {pozitieMax}");
    }
}
