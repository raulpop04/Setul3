using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema11
{
    public static void Solve()
    {
        Console.Write("Introduceti un numar natural n: ");
        int n = int.Parse(Console.ReadLine());

        PrintPrimesUpToN(n);
    }

    public static void PrintPrimesUpToN(int n)
    {
        bool[] isPrime = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= n; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        Console.WriteLine($"Numere prime mai mici sau egale cu {n}:");
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }

}

