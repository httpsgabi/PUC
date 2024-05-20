using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício005
{
    internal class Program
    {
        static int ContaVogais(char[] vetLetras)
        {
            int quantVogais = 0;
            char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < vetLetras.Length; i++)
            {
                for (int j = 0; j < vogais.Length; j++)
                {
                    if (vetLetras[i] == vogais[j])
                    {
                        quantVogais++;
                    }
                }
            }

            return quantVogais;
        }

        static void Main(string[] args)
        {
            int tamVetor;

            Console.WriteLine("Digite a o tamanho do seu vetor de caracteres: ");
            tamVetor = int.Parse(Console.ReadLine());

            char[] vetLetras = new char[tamVetor];

            for (int i = 0; i < tamVetor; i++)
            {
                Console.Write($"\nDigite a letra {i}: ");
                vetLetras[i] = char.Parse(Console.ReadLine());  
            }

            Console.WriteLine($"\nA quantidade de vogais é: {ContaVogais(vetLetras)}");

            Console.ReadLine();
        }
    }
}
