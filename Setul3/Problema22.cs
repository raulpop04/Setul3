using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema22
{
    public static void Solve()
    {
        Console.WriteLine("Introduceti primul vector (v1):");
        int[] v1 = ReadBinaryVector();

        Console.WriteLine("Introduceti al doilea vector (v2):");
        int[] v2 = ReadBinaryVector();


        int[] intersectie = Intersection(v1, v2);
        Console.WriteLine($"Intersectia v1 si v2: {ArrayToString(intersectie)}");

        int[] reuniune = Union(v1, v2);
        Console.WriteLine($"Reuniunea v1 si v2: {ArrayToString(reuniune)}");

        int[] diferentaV1V2 = Difference(v1, v2);
        Console.WriteLine($"Diferenta v1 - v2: {ArrayToString(diferentaV1V2)}");
  
        int[] diferentaV2V1 = Difference(v2, v1);
        Console.WriteLine($"Diferenta v2 - v1: {ArrayToString(diferentaV2V1)}");
    }

    public static int[] ReadBinaryVector()
    {
        string[] input = Console.ReadLine().Split(' ');
        return Array.ConvertAll(input, int.Parse);
    }

    public static int[] Intersection(int[] v1, int[] v2)
    {
        List<int> result = new List<int>();
        int i = 0, j = 0;

        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == 1 && v2[j] == 1)
            {
                result.Add(1);
                i++;
                j++;
            }
            else if (v1[i] == 0 && v2[j] == 0)
            {
                i++;
                j++;
            }
            else if (v1[i] == 1)
            {
                j++;
            }
            else
            {
                i++;
            }
        }

        return result.ToArray();
    }

    public static int[] Union(int[] v1, int[] v2)
    {
        List<int> result = new List<int>();
        int i = 0, j = 0;

        while (i < v1.Length || j < v2.Length)
        {
            if (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == 1 && v2[j] == 1)
                {
                    result.Add(1);
                    i++;
                    j++;
                }
                else if (v1[i] == 0 && v2[j] == 0)
                {
                    result.Add(0);
                    i++;
                    j++;
                }
                else if (v1[i] == 1)
                {
                    result.Add(1);
                    i++;
                }
                else
                {
                    result.Add(1);
                    j++;
                }
            }
            else if (i < v1.Length)
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

        return result.ToArray();
    }

    public static int[] Difference(int[] v1, int[] v2)
    {
        List<int> result = new List<int>();
        int i = 0, j = 0;

        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == 1 && v2[j] == 0)
            {
                result.Add(1);
                i++;
            }
            else if (v1[i] == 1 && v2[j] == 1)
            {
                i++;
                j++;
            }
            else if (v1[i] == 0)
            {
                i++;
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
