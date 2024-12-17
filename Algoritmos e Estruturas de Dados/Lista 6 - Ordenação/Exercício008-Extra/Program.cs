using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Exercício 8: Considere o vetor [10, 7, 8, 9, 1, 5]. Execute o algoritmo Quicksort no vetor e mostre detalhadamente cada chamada recursiva, os pivôs escolhidos e os subvetores resultantes após a partição.

*/
namespace Exercício008_Extra
{
    internal class Program
    {
        static void QuickSort(int[] array, int esq, int dir)
        {
            int i = esq, j = dir, pivo =  array[(esq + dir) / 2];

            while (i <= j)
            {
                while (array[i] < pivo)
                {
                    i++;
                }
                while (array[j] > pivo)
                {
                    j--;        
                }

                if (i<=j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (esq < j)
            {
                QuickSort(array, esq, j); 
            }
            if (dir > i)
            {
                QuickSort(array, i, dir);
            }
        }
        static void Main(string[] args)
        {
            int[] vet = {10, 7, 8, 9, 1, 5};

            Console.WriteLine("Vetor ordenado:");
            QuickSort(vet, 0, vet.Length - 1);

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
