using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valeAlimentacao, valeTransporte, m2Produzidos, valorPago, valorm2, valorTotalm2;

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("\n---------------------------------------------------\nPedreiro " + i);
                Console.Write("\nDigite o valor do vale alimentação: ");
                valeAlimentacao = float.Parse(Console.ReadLine());

                Console.Write("\nDigite o valor do vale transporte: ");
                valeTransporte = float.Parse(Console.ReadLine());

                Console.Write("\nDigite quantos metros quadrados o pedreiro produziu: ");
                m2Produzidos = float.Parse(Console.ReadLine());

                if (m2Produzidos < 10)
                {
                    valorm2 = 10.0;
                    valorTotalm2 = valorm2 * m2Produzidos;

                }
                else if (m2Produzidos >= 10 || m2Produzidos <= 20)
                {
                    valorm2 = 11.5;
                    valorTotalm2 = valorm2 * m2Produzidos;
                }
                else
                {
                    valorm2 = 13.0;
                    valorTotalm2 = valorm2 * m2Produzidos;
                }

                valorPago = valeAlimentacao + (valeTransporte * 2) + valorTotalm2;
                Console.WriteLine("O valor do pedreiro " + i + " a ser pago é de: " + valorPago);

            }

            Console.ReadLine();
        }
    }
}
