using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício007
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

            Console.Write("\nElementos em x que não existem em y:");
            for (int i = 0; i < vetA.Length; i++)
            {
                bool encontrado = false;
                for (int j = 0; j < vetB.Length; j++)
                {
                    if (vetA[i] == vetB[j])
                    {
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine(vetA[i]);
                }
            }

            Console.WriteLine($"\n----------------------------------------------------------------------------");

            for (int i = 0; i < vetA.Length; i++)
            {
                for (int j = 0; j < vetB.Length; j++)
                {
                    if (vetA[i] == vetB[j])
                    {
                        Console.Write($"\nO elemento {vetB[j]}, aparece nos dois vetores");
                    }
                }
            }

            Console.WriteLine($"\n----------------------------------------------------------------------------");
            Console.WriteLine("\nUnião entre x e y (sem elementos repetidos):");
            List<double> uniao = new List<double>();

            for (int i = 0; i < vetA.Length; i++)
            {
                bool repetido = false;
                for (int j = 0; j < uniao.Count; j++)
                {
                    if (uniao[j] == vetA[i])
                    {
                        repetido = true;
                        break;
                    }
                }
                if (!repetido)
                {
                    uniao.Add(vetA[i]);
                }
            }

            for (int i = 0; i < vetB.Length; i++)
            {
                bool repetido = false;
                for (int j = 0; j < uniao.Count; j++)
                {
                    if (uniao[j] == vetB[i])
                    {
                        repetido = true;
                        break;
                    }
                }
                if (!repetido)
                {
                    uniao.Add(vetB[i]);
                }
            }

            int k = 0;
            while (k < uniao.Count)
            {
                Console.WriteLine(uniao[k]);
                k++;
            }

            Console.ReadLine();
        }
    }
}
