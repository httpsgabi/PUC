using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite sua idade para saber em qual categoria de natação você se enquadra: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Infantil A");
            }
            else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Infantil B");
            }
            else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Junior A");
            }
            else if (idade >= 15 && idade <= 17)
            {
                Console.WriteLine("Junior B");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Sênior");
            }
            else
            {
                Console.WriteLine("Idade inválida");
            }

            Console.ReadLine();
        }
    }
}
