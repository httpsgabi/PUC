using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex009___lista7
{
    class Program
    {
        static void ObterMaiorMenor(float[] vetor, out float menor, out float maior)
        {

            maior = 0;
            menor = 100000;

            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] > maior)
                {
                    maior = vetor[i];
                }
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }

        }
        static void Main(string[] args)
        {
            int tamVet;

            Console.Write($"Digite qual o tamanho do vetor deejado: ");
            tamVet = int.Parse(Console.ReadLine());

            float[] vetor = new float[tamVet];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"\nDigite o numero {i+1}: ");
                vetor[i] = float.Parse(Console.ReadLine());
            }

            ObterMaiorMenor(vetor, out float maior, out float menor);

            Console.WriteLine($"O maior valor é: {maior} \nO menor valor é: {menor}");

            Console.ReadLine();
        }
    }
}
