using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema26
{
    public static void Solve()
    {
        Console.Write("Introduceti lungimea primului numar: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti lungimea celui de-al doilea numar: ");
        int n2 = int.Parse(Console.ReadLine());

        int[] numar1 = new int[n1];
        int[] numar2 = new int[n2];

        Console.WriteLine("Introduceti cifrele primului numar:");
        for (int i = 0; i < n1; i++)
        {
            Console.Write($"Cifra {i + 1}: ");
            numar1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Introduceti cifrele celui de-al doilea numar:");
        for (int i = 0; i < n2; i++)
        {
            Console.Write($"Cifra {i + 1}: ");
            numar2[i] = int.Parse(Console.ReadLine());
        }

        int[] suma = Aduna(numar1, numar2);
        Console.Write("Suma numerelor este: ");
        AfiseazaNumar(suma);

        int[] diferenta = Scade(numar1, numar2);
        Console.Write("Diferenta numerelor este: ");
        AfiseazaNumar(diferenta);

        int[] produs = Inmulteste(numar1, numar2);
        Console.Write("Produsul numerelor este: ");
        AfiseazaNumar(produs);
    }

    public static int[] Aduna(int[] numar1, int[] numar2)
    {
        List<int> rezultat = new List<int>();
        int transport = 0;

        int lungimeMaxima = Math.Max(numar1.Length, numar2.Length);
        Array.Reverse(numar1);
        Array.Reverse(numar2);

        for (int i = 0; i < lungimeMaxima; i++)
        {
            int cifra1 = (i < numar1.Length) ? numar1[i] : 0;
            int cifra2 = (i < numar2.Length) ? numar2[i] : 0;

            int sumaCifrelor = cifra1 + cifra2 + transport;
            rezultat.Add(sumaCifrelor % 10);
            transport = sumaCifrelor / 10;
        }

        if (transport > 0)
        {
            rezultat.Add(transport);
        }

        rezultat.Reverse();
        return rezultat.ToArray();
    }


    public static int[] Scade(int[] numar1, int[] numar2)
    {
        List<int> rezultat = new List<int>();
        int imprumut = 0;

        int lungimeMaxima = Math.Max(numar1.Length, numar2.Length);
        Array.Reverse(numar1);
        Array.Reverse(numar2);

        for (int i = 0; i < lungimeMaxima; i++)
        {
            int cifra1 = (i < numar1.Length) ? numar1[i] : 0;
            int cifra2 = (i < numar2.Length) ? numar2[i] : 0;

            int diferentaCifrelor = cifra1 - cifra2 - imprumut;

            if (diferentaCifrelor < 0)
            {
                diferentaCifrelor += 10;
                imprumut = 1;
            }
            else
            {
                imprumut = 0;
            }

            rezultat.Add(diferentaCifrelor);
        }

        rezultat.Reverse();

        while (rezultat.Count > 1 && rezultat[0] == 0)
        {
            rezultat.RemoveAt(0);
        }

        return rezultat.ToArray();
    }

    public static int[] Inmulteste(int[] numar1, int[] numar2)
    {
        int lungimeMaxima = numar1.Length + numar2.Length;
        int[] rezultat = new int[lungimeMaxima];

        Array.Reverse(numar1);
        Array.Reverse(numar2);

        for (int i = 0; i < numar1.Length; i++)
        {
            int transport = 0;

            for (int j = 0; j < numar2.Length; j++)
            {
                int produsCifre = numar1[i] * numar2[j] + rezultat[i + j] + transport;
                rezultat[i + j] = produsCifre % 10;
                transport = produsCifre / 10;
            }

            rezultat[i + numar2.Length] += transport;
        }

        while (rezultat.Length > 1 && rezultat[0] == 0)
        {
            int[] nouRezultat = new int[rezultat.Length - 1];
            Array.Copy(rezultat, 1, nouRezultat, 0, nouRezultat.Length);
            rezultat = nouRezultat;
        }

        Array.Reverse(rezultat);
        return rezultat;
    }
    public static void AfiseazaNumar(int[] numar)
    {
        foreach (int cifra in numar)
        {
            Console.Write(cifra);
        }
        Console.WriteLine();
    }
}

