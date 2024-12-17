using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Exercício 6: Considere o vetor [3, 1, 4, 1, 5, 9]. Aplique o algoritmo Inserção e descreva como o vetor é modificado após cada iteração do algoritmo.

    1 = [3, 1, 4, 1, 5, 9]
    2 = [1, 3, 4, 1, 5, 9]
    3 = [1, 1, 3, 4, 5, 9]
*/

namespace Exercício006_Extra
{
    internal class Program
    {
        static void Insercao(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;

                while ((j >= 0) && (array[j] > temp))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] vet = { 3, 1, 4, 1, 5, 9 };

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
