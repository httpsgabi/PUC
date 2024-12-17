using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercício 5: Dado o vetor [5, 8, 2, 9, 1], aplique o algoritmo Inserção para ordená-lo em ordem crescente.
	Mostre as modificações do vetor após cada inserção de um novo elemento
	na posição correta.
	Quantas trocas e comparações são feitas durante o processo?

    Resposta: 9 comparações e 6 trocas

    1 = [5, 8, 2, 9, 1];
    2 = [2, 5, 8, 9, 1];
    3 = [1, 2, 5, 8, 9];
*/

namespace Exercício005_Extra
{
    internal class Program
    {
        static void Insercao(int[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                int tmp = array[i];
                int j = i - 1;
                while ((j >= 0) && (array[j] > tmp))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = tmp;
            }

        }
        static void Main(string[] args)
        {
            int[] vet = { 5, 8, 2, 9, 1 };

            Console.WriteLine("Vetor ordenado:");
            Insercao(vet);

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}

