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
            Console.WriteLine("Digite quatro números inteiros e positivos, o primeiro deles deve estar entre 1 e 4: ");
            int operacao = int.Parse(Console.ReadLine());
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());

            if ((operacao > 0 && operacao <= 4) && (num1 >= 0 && num2 >= 0 && num3 >= 0)) { 
                if (operacao == 1) {
                    double geometrica = Math.Sqrt(num1 * num2 * num3);
                    Console.WriteLine("Você escolheu a opção 1, referente a média geométrica, o resultado é: " + Math.Round(geometrica, 2));
                }
                else if (operacao == 2)
                {
                    double ponderada = num1 + (2 * num2) + (3 * num3) / 6;
                    Console.WriteLine("Você escolheu a opção 2, referente a média ponderada, o resultado é: " + Math.Round(ponderada, 2));
                }
                else if (operacao == 3)
                {
                    if (num1 != 0 && num3 != 0 && num3 != 0)
                    {
                        double harmonica = 1 / ((1 / num1) + (1 / num2) + (1 / num3));
                        Console.WriteLine("Você escolheu a opção 3, referente a média hamônica, o resultado é: " + Math.Round(harmonica, 2));
                    }
                    else
                    {
                        Console.WriteLine("A opção 3 refere-se a média harmônica, nenhum dos números pode ser 0 por estarem no divisor de uma fração");
                    }
                }
                else if (operacao == 4)
                {
                    double aritmetica = (num1 + num2 + num3) / 3;
                    Console.WriteLine("Você escolheu a opção 4, referente a média geométrica, o resultado é: " + Math.Round(aritmetica, 2));
                }
            }
            else
            {
                Console.WriteLine("Primeiro número inválido");
            }

            Console.ReadLine();
        }
    }
}
