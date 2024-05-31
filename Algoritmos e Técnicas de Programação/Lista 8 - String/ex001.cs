using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String palavra;
            char letra;
            int count = 0;

            Console.Write("Digite uma palavra e a letra que quer contar nessa palavra: ");
            palavra = Console.ReadLine();
            letra = char.Parse(Console.ReadLine());

            foreach (char c in palavra)
            {
                if(c == char.ToUpper(letra) || c == char.ToLower(letra))
                {
                    count++;
                }
            }

            Console.WriteLine($"A quantidade de vezes que '{letra}' apareceu em '{palavra}' foi de: {count}");

            Console.ReadLine();
        }
    }
}
