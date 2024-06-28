using System;

namespace Exercício002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String palavra;
            char[] vetVogais = {'a','e','i','o','u','A','E','I','O','U'};
            int quantVogais = 0, quantConsoantes = 0;
            bool ehVogal;

            Console.WriteLine("Digite uma palavra para contar suas vogais e suas consoantes: ");
            palavra = Console.ReadLine();

            for (int i = 0; i < palavra.Length; i++)
            {
                ehVogal = false;
                for (int j = 0; j < vetVogais.Length; j++)
                {
                    if (palavra[i] == vetVogais[j])
                    {
                        quantVogais++;
                        ehVogal = true;
                    }
                }
                if (ehVogal == false)
                {
                    quantConsoantes++;
                }
            }

            Console.WriteLine($"A quantidade de vogais é: {quantVogais};\n A quantidade de consoantes é: {quantConsoantes}");
            Console.ReadLine();
        }
    }
}
