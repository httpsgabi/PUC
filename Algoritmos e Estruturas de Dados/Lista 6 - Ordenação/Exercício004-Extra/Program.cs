using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004_Extra
{
    /*
     Exercício 4: Dado o vetor [8, 19, 3, 12, 5], faça uma análise de complexidade do algoritmo Bolha. Em seguida, simule a execução do algoritmo até que o vetor esteja ordenado e mostre como o vetor se modifica a cada iteração. 
    
    Complexidade: O(n²)
     */
    internal class Program
    {
        static void BubbleSort(int[] vet)
        {
            int temp;
            for (int i = 0; i < vet.Length - 1; i++)
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
            int[] vet = { 8, 19, 3, 12, 5 };

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
