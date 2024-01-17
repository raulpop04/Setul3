using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Problema25
{
    public static void Solve()
    {
        Console.WriteLine("Introduceti primul vector sortat crescator:");
        int[] v1 = ReadIntArray();

        Console.WriteLine("Introduceti al doilea vector sortat crescator:");
        int[] v2 = ReadIntArray();

        int[] rezultatInterclasare = MergeSortedArrays(v1, v2);
        Console.WriteLine($"Vectorul interclasat: {ArrayToString(rezultatInterclasare)}");
    }

    public static int[] ReadIntArray()
    {
        string[] input = Console.ReadLine().Split(' ');
        return Array.ConvertAll(input, int.Parse);
    }

    public static int[] MergeSortedArrays(int[] v1, int[] v2)
    {
        int n1 = v1.Length;
        int n2 = v2.Length;
        int[] rezultat = new int[n1 + n2];

        int i = 0, j = 0, k = 0;

        while (i < n1 && j < n2)
        {
            if (v1[i] <= v2[j])
            {
                rezultat[k] = v1[i];
                i++;
            }
            else
            {
                rezultat[k] = v2[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            rezultat[k] = v1[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            rezultat[k] = v2[j];
            j++;
            k++;
        }

        return rezultat;
    }

    public static string ArrayToString(int[] array)
    {
        return string.Join(", ", array);
    }

}

