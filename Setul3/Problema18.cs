using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema18
{
    public static void Solve()
    {
        Console.Write("Introduceti gradul polinomului (n): ");
        int n = int.Parse(Console.ReadLine());

        double[] coeficienti = new double[n + 1];

        Console.WriteLine("Introduceti coeficientii polinomului (de la cel mai mic la cel mai mare grad):");
        for (int i = 0; i <= n; i++)
        {
            Console.Write($"Coeficientul pentru x^{i}: ");
            coeficienti[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Introduceti valoarea punctului x: ");
        double x = double.Parse(Console.ReadLine());

        double rezultat = EvaluatePolynomial(coeficienti, x);
        Console.WriteLine($"Valoarea polinomului in punctul {x}: {rezultat}");
    }

    public static double EvaluatePolynomial(double[] coeficienti, double x)
    {
        double rezultat = 0;

        for (int i = 0; i < coeficienti.Length; i++)
        {
            rezultat += coeficienti[i] * Math.Pow(x, i);
        }

        return rezultat;
    }

}

