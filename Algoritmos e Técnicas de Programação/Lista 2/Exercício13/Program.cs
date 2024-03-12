using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício13
{
    internal class Program
    {
        static void Main(string[] args)            
        {
            Console.WriteLine("Digite um ano para saber se ele é bissexto ou não: ");
            int ano = int.Parse(Console.ReadLine());

            bool ehBissexto = (ano % 400 == 0) || ((ano % 4 == 0) && (ano % 100 != 0)) ? true : false;
            Console.WriteLine(ehBissexto ? "É bissexto" : "Não é bissexto");

            Console.ReadLine();
        }
    }
}
