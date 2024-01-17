using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema20
{
    public static void Solve()
    {
        Console.WriteLine("Introduceti siragul s1 (ex. 'ABAB'):");
        string s1 = Console.ReadLine();

        Console.WriteLine("Introduceti siragul s2 (ex. 'BABA'):");
        string s2 = Console.ReadLine();

        int numarSuprapuneri = CountOverlaps(s1, s2);
        Console.WriteLine($"Numarul de suprapuneri ale siragurilor este: {numarSuprapuneri}");
    }

    public static int CountOverlaps(string s1, string s2)
    {
        int n = s1.Length;
        int m = s2.Length;

        string concatenat = s1 + s1; 

        int numarSuprapuneri = 0;

        for (int i = 0; i < n; i++)
        {
            bool match = true;

            for (int j = 0; j < m; j++)
            {
                if (concatenat[i + j] != s2[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
            {
                numarSuprapuneri++;
            }
        }

        return numarSuprapuneri;
    }

}

