using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numerador e denominador da fração para saber seu resultado: ");

            float numerador = float.Parse(Console.ReadLine());
            float denominador = float.Parse(Console.ReadLine());

            float fracao = numerador / denominador;

            Console.WriteLine("O resultado é: " + Math.Round(fracao, 2));

            Console.ReadLine();
        }
    }
}
