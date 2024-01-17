using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema19
{
    public static void Solve()
    {
        Console.WriteLine("Introduceti vectorul s:");
        int[] s = ReadIntArray();

        Console.WriteLine("Introduceti vectorul p:");
        int[] p = ReadIntArray();

        int numarAparitii = CountOccurrences(s, p);
        Console.WriteLine($"Vectorul p apare in vectorul s de {numarAparitii} ori.");
    }

    public static int[] ReadIntArray()
    {
        string[] input = Console.ReadLine().Split(' ');
        return Array.ConvertAll(input, int.Parse);
    }

    public static int CountOccurrences(int[] s, int[] p)
    {
        if (p.Length > s.Length)
        {
            return 0; 
        }

        int numarAparitii = 0;


        const int baza = 256; 
        int mod = 997; 

        int hashP = 0;
        int hashS = 0;
        int putereBaza = 1;

        for (int i = 0; i < p.Length; i++)
        {
            hashP = (hashP * baza + p[i]) % mod;
            hashS = (hashS * baza + s[i]) % mod;
            putereBaza = (putereBaza * baza) % mod;
        }

        for (int i = 0; i <= s.Length - p.Length; i++)
        {
            if (hashP == hashS)
            {
                bool match = true;

                for (int j = 0; j < p.Length; j++)
                {
                    if (s[i + j] != p[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    numarAparitii++;
                }
            }

            if (i < s.Length - p.Length)
            {

                hashS = (hashS * baza - s[i] * putereBaza + s[i + p.Length]) % mod;
                if (hashS < 0)
                {
                    hashS += mod;
                }
            }
        }

        return numarAparitii;
    }


}

