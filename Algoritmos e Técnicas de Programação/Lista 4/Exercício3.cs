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
            int i, count = 1;
            double precoKWH, quantidadeKWH, totalPagar, maiorConsumo = 0, menorConsumo = 10^10, consumoMedio = 0;

            for (i = 1; i <= 50; i++) {
                Console.WriteLine("\n---------------------------------------------------\nConsumidor " + i);
                Console.Write("\nDigite o preço do kWh: ");
                precoKWH = int.Parse(Console.ReadLine());

                Console.Write("\nDigite a quantidade de kWh consumidos no mês: ");
                quantidadeKWH = int.Parse(Console.ReadLine());

                totalPagar = precoKWH * quantidadeKWH;
                Console.Write("\nPreço total a ser pago: " + totalPagar);

                if (quantidadeKWH > maiorConsumo)
                {
                    maiorConsumo = quantidadeKWH;
                }
                if (quantidadeKWH < menorConsumo)
                {
                    menorConsumo = quantidadeKWH;
                }

                consumoMedio = consumoMedio + quantidadeKWH;

            }

            consumoMedio = consumoMedio / i;

            Console.WriteLine("\n---------------------------------------------------\n");
            Console.WriteLine("\nO maior consumo é: " + maiorConsumo);
            Console.WriteLine("O menor consumo é: " + menorConsumo);
            Console.WriteLine("O consumo médio é: " + consumoMedio);

            Console.ReadLine();
        }
    }
}
