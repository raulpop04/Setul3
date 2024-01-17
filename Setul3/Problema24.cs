using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema24
{
    public static void Solve()
    {
        Console.WriteLine("Introduceti primul vector binar (v1):");
        int[] v1 = ReadBinaryVector();

        Console.WriteLine("Introduceti al doilea vector binar (v2):");
        int[] v2 = ReadBinaryVector();


        int[] intersectie = IntersectionBinary(v1, v2);
        Console.WriteLine($"Intersectia v1 si v2: {ArrayToString(intersectie)}");

        int[] reuniune = UnionBinary(v1, v2);
        Console.WriteLine($"Reuniunea v1 si v2: {ArrayToString(reuniune)}");

        int[] diferentaV1V2 = DifferenceBinary(v1, v2);
        Console.WriteLine($"Diferenta v1 - v2: {ArrayToString(diferentaV1V2)}");

        int[] diferentaV2V1 = DifferenceBinary(v2, v1);
        Console.WriteLine($"Diferenta v2 - v1: {ArrayToString(diferentaV2V1)}");
    }

    public static int[] ReadBinaryVector()
    {
        string[] input = Console.ReadLine().Split(' ');
        return Array.ConvertAll(input, int.Parse);
    }

    public static int[] IntersectionBinary(int[] v1, int[] v2)
    {
        int n = Math.Min(v1.Length, v2.Length);
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            result[i] = v1[i] & v2[i];
        }

        return result;
    }

    public static int[] UnionBinary(int[] v1, int[] v2)
    {
        int n = Math.Max(v1.Length, v2.Length);
        int[] result = new int[n];

        for (int i = 0; i < v1.Length; i++)
        {
            result[i] = v1[i];
        }

        for (int i = 0; i < v2.Length; i++)
        {
            result[i] |= v2[i];
        }

        return result;
    }

    public static int[] DifferenceBinary(int[] v1, int[] v2)
    {
        int n = Math.Max(v1.Length, v2.Length);
        int[] result = new int[n];

        for (int i = 0; i < v1.Length; i++)
        {
            result[i] = v1[i] & ~v2[i];
        }

        return result;
    }

    public static string ArrayToString(int[] array)
    {
        return string.Join(", ", array);
    }

}
