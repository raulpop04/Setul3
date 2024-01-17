using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema31
{
    public static void Solve()
    {
        Console.WriteLine("Introduceti elementele vectorului (separate prin spatii):");
        int[] vector = ReadIntArray();

        int majoritar = GasesteElementMajoritar(vector);

        if (majoritar != int.MinValue)
        {
            Console.WriteLine($"Elementul majoritar este: {majoritar}");
        }
        else
        {
            Console.WriteLine("Nu exista element majoritar.");
        }
    }

    public static int[] ReadIntArray()
    {
        string[] input = Console.ReadLine().Split(' ');
        return Array.ConvertAll(input, int.Parse);
    }

    public static int GasesteElementMajoritar(int[] vector)
    {
        int majoritar = vector[0];
        int contor = 1;

        for (int i = 1; i < vector.Length; i++)
        {
            if (contor == 0)
            {
                majoritar = vector[i];
                contor = 1;
            }
            else if (vector[i] == majoritar)
            {
                contor++;
            }
            else
            {
                contor--;
            }
        }

        contor = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] == majoritar)
            {
                contor++;
            }
        }

        return contor > vector.Length / 2 ? majoritar : int.MinValue;
    }

}

