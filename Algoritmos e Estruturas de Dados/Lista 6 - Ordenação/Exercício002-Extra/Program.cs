using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 	Exercício 2: Dado o vetor [55, 23, 89, 12, 44, 66], descreva o comportamento do algoritmo de Seleção. Em cada passo do algoritmo, indique o índice do menor elemento encontrado e a troca realizada.

    1º = [55, 23, 89, 12, 44, 66] 
        posMenor = 3; 
        troca = 12 e 55

    2º = [12, 23, 89, 55, 44, 66] 
        posMenor = 1; 
        troca = 23 e 23

    3º = [12, 23, 89, 55, 44, 66] 
        posMenor = 4; 
        troca = 89 e 44

    4º = [12, 23, 44, 55, 89, 66] 
        posMenor = 3; 
        troca = 12 e 55

    5º = [12, 23, 44, 55, 89, 66] 
        posMenor = 5; 
        troca = 89 e 66

    6º = [12, 23, 44, 55, 89, 66] 

*/
namespace Exercício002_Extra
{
    internal class Program
    {
        static void Selecao(int[] vet)
        {
            for (int i = 0; i < vet.Length - 1; i++)
            {
                int posMenor = i;
                for (int j = i+1; j< vet.Length; j++)
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
            int[] vet = { 55, 23, 89, 12, 44, 66 };

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
