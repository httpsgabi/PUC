using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String string1, string2;

            Console.WriteLine("Digite duas palavras para comparar se elas são iguais: ");

            string1 = Console.ReadLine();
            string2 = Console.ReadLine();

            if(string1 == string2)
            {
                Console.WriteLine("Strings iguais! ");
            }
            else
            {
                int tamString1 = string1.Length;
                int tamString2 = string2.Length;

                if (tamString1 > tamString2)
                {
                    Console.WriteLine($"A palavra 1 é maior, e a junção é: '{string1 + string2}'");
                }
                else if (tamString2 > tamString1)
                {
                    Console.WriteLine($"A palavra 2 é maior, e a junção é: '{string1 + string2}'");
                } 
                else
                {
                    Console.WriteLine($"As strings tem o mesmo tamanho, e a junção é: '{string1 + string2}'");
                }
            }

            Console.ReadLine();
        }
    }
}
