using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o total gasto no estabelicimento: ");
            float totalGasto = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de gorjeta que deseja aplicar: ");
            float percentualGorjeta = float.Parse(Console.ReadLine());

            percentualGorjeta = (percentualGorjeta * totalGasto) / 100;
            float valorTotal = percentualGorjeta + totalGasto;

            Console.WriteLine("O valor total a ser pago é de: " + valorTotal);

            Console.ReadLine();
        }
    }
}
