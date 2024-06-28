using System;

namespace Exercício005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String palavra;
            bool ehPalindromo = true;
            int inicio = 0, fim;

            Console.WriteLine("Digite uma palavra para verificar se ela é um palíndromo ou não: ");
            palavra = Console.ReadLine();

            fim = palavra.Length - 1;

            // Compara os caracteres da string
            while (inicio < fim)
            {
                if (palavra[inicio] != palavra[fim])
                {
                    ehPalindromo = false;
                }
                inicio++;
                fim--;
            }

            if (ehPalindromo)
            {
                Console.WriteLine("É palíndromo");
            }
            else
            {
                Console.WriteLine("Não é palíndromo");
            }

            Console.ReadLine();
        }
    }
}
