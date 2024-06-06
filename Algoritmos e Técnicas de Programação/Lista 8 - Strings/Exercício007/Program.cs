using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase;
            int count = 1;

            Console.WriteLine($"Digite uma frase para calcular a quantidade de palavras");
            frase = Console.ReadLine();

            for ( int i = 0; i < frase.Length; i++ )
            {
                if (frase[i] == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine($"'{frase}' possui {count} palavras");
            Console.ReadLine();
        }
    }
}
