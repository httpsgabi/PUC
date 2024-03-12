using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação desejada");
            Console.WriteLine("Menu de Opções\r\n1. Somar dois números.\r\n2. Subtrair dois números.\r\n3. Multiplicação de dois números.\r\n4. Divisão de dois números.\r\nOpção: ");
            
            int opcao = int.Parse(Console.ReadLine());

            if(opcao == 1) {

                Console.WriteLine("Numero 1: ");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Numero 2: ");
                float num2 = float.Parse(Console.ReadLine());

                float soma = num1 + num2;
                Console.WriteLine("A soma é: " + soma);
            }
            else if (opcao == 2) {

                Console.WriteLine("Numero 1: ");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Numero 2: ");
                float num2 = float.Parse(Console.ReadLine());

                float subtracao = num1 - num2;
                Console.WriteLine("A subtração é: " + subtracao);
            }
            else if (opcao == 3) {

                Console.WriteLine("Numero 1: ");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Numero 2: ");
                float num2 = float.Parse(Console.ReadLine());

                float multiplicar = num1 * num2;
                Console.WriteLine("A multiplicação é: " + multiplicar);
            }
            else if (opcao == 4) {

                Console.WriteLine("Numero 1 (divisor): ");
                float divisor = float.Parse(Console.ReadLine());

                Console.WriteLine("Numero 2 (dividendo): ");
                float dividendo = float.Parse(Console.ReadLine());

                if(dividendo != 0)
                {
                    float dividir = divisor / dividendo;
                    Console.WriteLine("A divisão é: " + dividir);
                }
                else
                {
                    Console.WriteLine("Erro, divisor = 0");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

            Console.ReadLine();
        }
    }
}
