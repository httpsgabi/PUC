using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício005
{
    internal class Program
    {
        static int Negativos(int[] vet, int tamanho)
        {
            if (tamanho == 0)
            {
                return 0;
            }
            else
            {
                int contaNegativos = 0;

                if (vet[tamanho - 1] < 0)
                {
                    contaNegativos++;
                }

                return contaNegativos + Negativos(vet, tamanho -1);
            }
        }
        static void Main(string[] args)
        {
            int tamanho;

            Console.WriteLine("Digite o tamanho do vetor e seus números: ");
            tamanho = int.Parse(Console.ReadLine());

            int[] vet = new int[tamanho];

            Console.WriteLine("Digite os números do vetor:");

            for (int i = 0;  i < vet.Length; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(Negativos(vet, vet.Length));
            Console.ReadLine();
        }
        

    }
}
