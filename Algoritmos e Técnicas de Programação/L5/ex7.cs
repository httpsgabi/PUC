using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetA = new double[5];
            double[] vetB = new double[5];
            double soma, produto;

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.Write($"\nLista 1, item {i}: ");
                vetA[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\n----------------------------------------------------------------------------");

            for (int i = 0; i < vetB.Length; i++)
            {
                Console.Write($"\nLista 2, item {i}: ");
                vetB[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\n----------------------------------------------------------------------------");

            for (int i = 0; i < vetA.Length; i++)
            {
                soma = vetA[i] + vetB[i];
                Console.Write($"\nA soma entre o item {i} da lista 1, e o item {i} da lista 2 é: {soma}");
            }

            Console.WriteLine($"\n----------------------------------------------------------------------------");

            for (int i = 0; i < vetA.Length; i++)
            {
                produto = vetA[i] * vetB[i];
                Console.Write($"\nO produto entre o item {i} da lista 1, e o item {i} da lista 2 é: {produto}");
            }

            Console.WriteLine($"\n----------------------------------------------------------------------------");

            for (int i = 0; i < vetA.Length; i++)
            {
                for (int j = 0; j < vetB.Length; j++)
                {
                    if (vetA[i] == vetB[j])
                    {
                        Console.WriteLine($"O elemento {vetA[i]}, aparece apenas na lista 1");
                    }
                }
            }

            Console.WriteLine($"\n----------------------------------------------------------------------------");

            for (int i = 0; i < vetA.Length; i++)
            {
                for (int j = 0; j < vetB.Length; j++)
                {
                    if (vetA[i] == vetB[j])
                    {
                        Console.WriteLine($"O elemento {vetB[j]}, aparece nos dois vetores");
                    }
                }
            }


            Console.ReadLine();
        }
    }
}
