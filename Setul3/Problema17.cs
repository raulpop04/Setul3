using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema17
{
    public static void Solve()
    {
        Console.Write("Introduceti numarul in baza 10: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Introduceti baza b (1 < b < 17): ");
        int b = int.Parse(Console.ReadLine());

        string rezultat = ConvertToBaseB(n, b);

        Console.WriteLine($"Numarul {n} in baza {b}: {rezultat}");
    }

    public static string ConvertToBaseB(int n, int b)
    {
        if (n == 0)
        {
            return "0";
        }

        StringBuilder result = new StringBuilder();

        while (n > 0)
        {
            int rest = n % b;
            result.Insert(0, ToChar(rest));
            n /= b;
        }

        return result.ToString();
    }

    public static char ToChar(int digit)
    {
        if (digit < 10)
        {
            return (char)('0' + digit);
        }
        else
        {
            return (char)('A' + digit - 10);
        }
    }

}

