using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome, email = string.Empty;
            string[] nomes;

            Console.WriteLine("Digite seu nome completo para gerar seu email institucional: ");
            nome = Console.ReadLine();

            nomes = nome.Split(' ');

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    email += nomes[i].ToLower();
                    email += ".";
                }
                else
                {
                    email += nomes[i].ToLower();
                }
            }

            email += "@acme.br";

            Console.WriteLine($"{email}");
            Console.ReadLine();
        }
    }
}
