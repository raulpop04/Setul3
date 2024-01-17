using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema29
{
    public static void MergeSort(int[] vector, int stanga, int dreapta)
    {
        if (stanga < dreapta)
        {
            int mijloc = (stanga + dreapta) / 2;

            MergeSort(vector, stanga, mijloc);
            MergeSort(vector, mijloc + 1, dreapta);

            Interclasare(vector, stanga, mijloc, dreapta);
        }
    }

    private static void Interclasare(int[] vector, int stanga, int mijloc, int dreapta)
    {
        int n1 = mijloc - stanga + 1;
        int n2 = dreapta - mijloc;

        int[] stangaArray = new int[n1];
        int[] dreaptaArray = new int[n2];

        Array.Copy(vector, stanga, stangaArray, 0, n1);
        Array.Copy(vector, mijloc + 1, dreaptaArray, 0, n2);

        int i = 0, j = 0, k = stanga;

        while (i < n1 && j < n2)
        {
            if (stangaArray[i] <= dreaptaArray[j])
            {
                vector[k] = stangaArray[i];
                i++;
            }
            else
            {
                vector[k] = dreaptaArray[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            vector[k] = stangaArray[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            vector[k] = dreaptaArray[j];
            j++;
            k++;
        }
    }

}

