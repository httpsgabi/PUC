using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamVet;
            float soma, produto, diferenca, intersecao, uniao;
            
            Console.WriteLine("Digite o tamanho dos vetores");
            tamVet = int.Parse(Console.ReadLine());

            int[] vet1 = new int[tamVet];
            int[] vet2 = new int[tamVet];


            for (int i = 0; i < vet1.Length; i++)
            {
                Console.WriteLine($"Digite o numero {i} do vetor 1");
                vet1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o numero {i} do vetor 2");
                vet2[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------------");
            }

            for (int i = 0;i < vet1.Length;i++)
            {
                soma = vet1[i] + vet2[i];
                produto = vet1[i] + vet2[i];
                diferenca = vet1[i] - vet2[i];



                Console.WriteLine($"A soma dos vetores na posição {i} é: {soma}");
                Console.WriteLine($"O produto dos vetores na posição {i} é: {produto}");
                Console.WriteLine($"A diferença dos vetores na posição {i} é: {diferenca}");
                Console.WriteLine($"A interseção dos vetores na posição {i} é: {intersecao}");
                Console.WriteLine($"A união dos vetores na posição {i} é: {uniao}");
            }
        }
    }
}
