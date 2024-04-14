using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char resposta;
            double salario, faixa1, faixa2, faixa3, faixa4, descontoTotal;
            int faixaSalarial = 0;

            //const double aliquota1 = 7.5 / 100, aliquota2 = 9/100, aliquota3 = 12/100, aliquota4 = 14/100;

            Console.Write("Deseja informar o salário de um funcionário para calcular o desconto INSS? ");
            resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                do
                {
                    Console.Write("\nDigite o salário do funcionário: ");
                    salario = double.Parse(Console.ReadLine());

                    faixaSalarial = salario <= 1412.0 ? 1 : salario > 1412.0 && salario <= 2666.68 ? 2 : salario > 2666.68 && salario <= 4000.03 ? 3 :salario > 4000.03 && salario <= 7786.02 ? 4 : 5;

                    Console.WriteLine(faixaSalarial);

                    faixa1 = (1412.0 * 7.5) /100;
                    faixa2 = (1254.67 * 7.5) / 100;
                    faixa3 = (1333.34 * 12) / 100;
                    faixa4 = (3785.98 * 14) / 100;

                    if (faixaSalarial == 1)
                    {
                        descontoTotal = (salario * 7.5) / 100;
                        Console.Write("Desconto total: " + Math.Round(descontoTotal,3));
                    }
                    else if (faixaSalarial == 2)
                    {
                        descontoTotal = faixa1 + ((salario - 1412.0) * 7.5 / 100);
                        Console.Write("Desconto total: " + Math.Round(descontoTotal, 3));
                    }
                    else if (faixaSalarial == 3)
                    {
                        descontoTotal = faixa1 + faixa2 + ((salario - 2666.69) * 12 / 100);
                        Console.Write("Desconto total: " + Math.Round(descontoTotal, 3));
                    }
                    else if (faixaSalarial == 4)
                    {
                        descontoTotal = faixa1 + faixa2 + faixa3 + ((salario - 4000.04) * 14 / 100);
                        Console.Write("Desconto total: " + Math.Round(descontoTotal, 3));
                    }
                    else
                    {
                        descontoTotal = faixa1 + faixa2 + faixa3 + (3785.98 * 14 / 100);
                        Console.Write("Desconto total: " + Math.Round(descontoTotal, 3));
                    }

                    Console.Write("\nDeseja informar um novo salário?: ");
                    resposta = char.Parse(Console.ReadLine());

                } while (resposta == 's' || resposta == 'S');
            }

            Console.ReadLine();
        }
    }
}
