using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Exercício 1: Considere o seguinte vetor:
	[29, 10, 14, 37, 13]
	Aplique o algoritmo de ordenação Seleção para ordenar esse vetor de forma crescente.
	Quantos passos você precisa para ordenar completamente o vetor? Mostre a cada iteração qual é o vetor após a troca.

    Passos: 

    1º = [10, 29, 14, 37, 13]
    2º = [10, 13, 14, 37, 29]
    3º = [10, 13, 14, 37, 29]
    4º = [10, 13, 14, 29, 37]
 */

namespace Exercício001_Extra
{
    internal class Program
    {
        static void Selecao(int[] vet)
        {
            for ( int i = 0;i < vet.Length - 1; i++)
            {
                int posMenor = i;
                for ( int j = i + 1; j < vet.Length; j++)
                {
                    if (vet[posMenor] > vet[j])
                    {
                        posMenor = j;
                    }
                }
                int temp = vet[posMenor];
                vet[posMenor] = vet[i];
                vet[i] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] vet = { 29, 10, 14, 37, 13 };

            Console.WriteLine("Vetor ordenado:");
            Selecao(vet);

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}

