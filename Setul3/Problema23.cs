using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema23
{
    public static void Solve()
    {
        Console.WriteLine("Introduceti primul vector (v1) in ordine crescatoare:");
        int[] v1 = ReadIntArray();

        Console.WriteLine("Introduceti al doilea vector (v2) in ordine crescatoare:");
        int[] v2 = ReadIntArray();


        int[] intersectie = IntersectionOrdered(v1, v2);
        Console.WriteLine($"Intersectia v1 si v2: {ArrayToString(intersectie)}");

        int[] reuniune = UnionOrdered(v1, v2);
        Console.WriteLine($"Reuniunea v1 si v2: {ArrayToString(reuniune)}");

        int[] diferentaV1V2 = DifferenceOrdered(v1, v2);
        Console.WriteLine($"Diferenta v1 - v2: {ArrayToString(diferentaV1V2)}");

        int[] diferentaV2V1 = DifferenceOrdered(v2, v1);
        Console.WriteLine($"Diferenta v2 - v1: {ArrayToString(diferentaV2V1)}");
    }

    public static int[] ReadIntArray()
    {
        string[] input = Console.ReadLine().Split(' ');
        return Array.ConvertAll(input, int.Parse);
    }

    public static int[] IntersectionOrdered(int[] v1, int[] v2)
    {
        List<int> result = new List<int>();
        int i = 0, j = 0;

        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == v2[j])
            {
                result.Add(v1[i]);
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        return result.ToArray();
    }

    public static int[] UnionOrdered(int[] v1, int[] v2)
    {
        List<int> result = new List<int>();
        int i = 0, j = 0;

        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == v2[j])
            {
                result.Add(v1[i]);
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                result.Add(v1[i]);
                i++;
            }
            else
            {
                result.Add(v2[j]);
                j++;
            }
        }

        while (i < v1.Length)
        {
            result.Add(v1[i]);
            i++;
        }

        while (j < v2.Length)
        {
            result.Add(v2[j]);
            j++;
        }

        return result.ToArray();
    }

    public static int[] DifferenceOrdered(int[] v1, int[] v2)
    {
        List<int> result = new List<int>();
        int i = 0, j = 0;

        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == v2[j])
            {
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                result.Add(v1[i]);
                i++;
            }
            else
            {
                j++;
            }
        }

        while (i < v1.Length)
        {
            result.Add(v1[i]);
            i++;
        }

        return result.ToArray();
    }

    public static string ArrayToString(int[] array)
    {
        return string.Join(", ", array);
    }

}

