using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema21
{
    public static void Solve()
    {
        Console.WriteLine("Introduceti primul vector:");
        string[] vector1 = Console.ReadLine().Split(' ');

        Console.WriteLine("Introduceti al doilea vector:");
        string[] vector2 = Console.ReadLine().Split(' ');

        int rezultatComparatie = CompareArraysLexicographically(vector1, vector2);

        if (rezultatComparatie < 0)
        {
            Console.WriteLine("Primul vector apare primul in dictionar.");
        }
        else if (rezultatComparatie > 0)
        {
            Console.WriteLine("Al doilea vector apare primul in dictionar.");
        }
        else
        {
            Console.WriteLine("Vectorii sunt egali din punct de vedere lexicografic.");
        }
    }

    public static int CompareArraysLexicographically(string[] vector1, string[] vector2)
    {
        int minLength = Math.Min(vector1.Length, vector2.Length);

        for (int i = 0; i < minLength; i++)
        {
            int comparatie = string.Compare(vector1[i], vector2[i]);

            if (comparatie != 0)
            {
                return comparatie;
            }
        }

        return vector1.Length - vector2.Length;
    }

}

