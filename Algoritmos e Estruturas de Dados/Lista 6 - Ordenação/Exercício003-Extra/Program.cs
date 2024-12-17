using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Exercício 3: Considere o vetor [34, 7, 23, 32, 5, 62].

	Aplique o algoritmo Bolha para ordenar o vetor em ordem crescente.
	Quantas comparações e trocas são feitas até o vetor ficar ordenado? Mostre o estado do vetor após cada passagem.


    1º = [ 5, 34, 7, 23, 32, 62 ] 5 comparações e 4 trocas

    2º = [ 5, 7, 34, 23, 32, 62 ] 4 comparações e 1 troca

    3º = [ 5, 7, 23, 34, 32, 62 ] 3 comprações e 1 troca

    4º = [5, 7, 23, 32, 34, 62 ] 2 comprações e 0 trocas

 */
namespace Exercício003_Extra
{
    internal class Program
    {
        static void BubbleSort(int[] vet)
        {
            int temp;
            for (int i = 0; i < vet.Length -  1; i++)
            {
                for (int j = vet.Length - 1; j > i; j--)
                {
                    if (vet[j] < vet[j-1])
                    {
                        temp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = temp;
                    }
                    
                }
            }
        }
        static void Main(string[] args)
        {
            int[] vet = { 34, 7, 23, 32, 5, 62 };

            Console.WriteLine("Vetor ordenado:");
            BubbleSort(vet);

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
