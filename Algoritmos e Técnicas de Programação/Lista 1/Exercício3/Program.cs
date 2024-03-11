//Exercício 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit para converte-la para graus Celsius");
            int temperatura = int.Parse(Console.ReadLine());

            int Celsius = (5 * ((temperatura - 32)) / 9;

            Console.WriteLine("A temperatura em Celsius é: " + Celsius);
            Console.ReadLine();
        }
    }
}
