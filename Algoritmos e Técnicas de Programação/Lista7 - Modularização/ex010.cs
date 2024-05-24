using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex009___lista7
{
    class Program
    {
        static void LerVetor(int[] vet)
        {
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write($"\nDigite o valor {i+1}: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
        }
        static int ComparaMatriculas(int[] vet1, int[] vet2)
        {
            int[] vetResultados = new int[10];

            for (int i = 0; i < vet1.Length; i++)
            {
                for (int j = 0; j < vet2.Length; i++)
                {
                    if(vet1[i] == vet2[j])
                    {
                        vetResultados[i] = vet1[i];
                    }
                }
            }

            return vetResultados[10];
        }
        static void Main(string[] args)
        {

            int[] vet1 = new int[10];
            LerVetor(vet1);

            Console.WriteLine("----------------------------------------------");

            int[] vet2 = new int[10];
            LerVetor(vet2);

            int[] vetResultado = ComparaMatriculas(vet1, vet2);

            for (int i = 0; i < vetResultado.Length; i++)
            {
                Console.Write($"As matrícula repetidas são: {vetResultados[i]}");
            }

            Console.ReadLine();
        }
    }
}
