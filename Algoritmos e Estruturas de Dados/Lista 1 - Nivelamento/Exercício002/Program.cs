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
            int num, temp = 1;

            Console.WriteLine("Digite um numero inteiro N, para exibir o triângulo de Floyd");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(temp + " ");
                    temp++;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
