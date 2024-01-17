using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Problema28
{
    public static void QuickSort(int[] vector, int stanga, int dreapta)
    {
        if (stanga < dreapta)
        {
            int pivot = Partitionare(vector, stanga, dreapta);

            QuickSort(vector, stanga, pivot - 1);
            QuickSort(vector, pivot + 1, dreapta);
        }
    }

    private static int Partitionare(int[] vector, int stanga, int dreapta)
    {
        int pivot = vector[dreapta];
        int i = stanga - 1;

        for (int j = stanga; j < dreapta; j++)
        {
            if (vector[j] < pivot)
            {
                i++;
                SchimbaElemente(vector, i, j);
            }
        }

        SchimbaElemente(vector, i + 1, dreapta);
        return i + 1;
    }

    private static void SchimbaElemente(int[] vector, int index1, int index2)
    {
        int temp = vector[index1];
        vector[index1] = vector[index2];
        vector[index2] = temp;
    }

}
