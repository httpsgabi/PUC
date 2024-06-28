using System;

namespace Exercício002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String palavra, palavraAux = string.Empty;

            Console.WriteLine("Digite uma palavra para escrevê-la ao contrário: ");
            palavra = Console.ReadLine();

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                palavraAux += palavra[i];
            }

            Console.WriteLine($"A palavra escrita ao contrário é: {palavraAux}");

            Console.ReadLine();
        }
    }
}
