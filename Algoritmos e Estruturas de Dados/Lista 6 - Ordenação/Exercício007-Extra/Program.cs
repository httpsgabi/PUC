using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 7: Dado o vetor [13, 19, 8, 7, 2, 3], execute o algoritmo Quicksort para ordenar esse vetor em ordem crescente.
Mostre os passos do algoritmo, incluindo as escolhas de pivôs e os particionamentos feitos.
	Quantos passos o algoritmo realiza até o vetor ser totalmente ordenado?
*/

namespace Exercício007_Extra
{
    internal class Program
    {
        static void QuickSort(int[] array, int esq, int dir)
        {
            int i = esq, j = dir;
            int pivo = array[(esq + dir) / 2];

            while (i <= j) { 
                while (array[i] < pivo)
                {
                    i++;
                }
                while (array[j] > pivo)
                {
                    j--;
                }
                if (i <= j)
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
            if (i < dir)
            {
                QuickSort(array, i, dir);
            }
                
        }
        static void Main(string[] args)
        {
            int[] vet = { 8, 19, 3, 12, 5 };

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
