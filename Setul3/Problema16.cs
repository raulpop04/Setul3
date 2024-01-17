using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema16
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

        int cmmdc = CalculateCMDC(vector);
        Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {cmmdc}");
    }

    public static int CalculateCMDC(int[] vector)
    {
        int cmmdc = vector[0];

        for (int i = 1; i < vector.Length; i++)
        {
            cmmdc = CalculateGCD(cmmdc, vector[i]);

            if (cmmdc == 1) 
            {
                break;
            }
        }

        return cmmdc;
    }

    public static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

}

