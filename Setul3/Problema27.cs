using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema27
{
    public static void Solve()
    {
        Console.WriteLine("Introduceti vectorul:");
        int[] vector = ReadIntArray();

        Console.WriteLine("Introduceti indexul:");
        int index = int.Parse(Console.ReadLine());

        int valoareDupaSortare = ValueAfterSorting(vector, index);
        Console.WriteLine($"Valoarea dupa sortare la indexul {index}: {valoareDupaSortare}");
    }

    public static int[] ReadIntArray()
    {
        string[] input = Console.ReadLine().Split(' ');
        return Array.ConvertAll(input, int.Parse);
    }

    public static int ValueAfterSorting(int[] vector, int index)
    {
        int[] copieVector = new int[vector.Length];
        Array.Copy(vector, copieVector, vector.Length);

        Array.Sort(copieVector);
        return copieVector[index];
    }

}

