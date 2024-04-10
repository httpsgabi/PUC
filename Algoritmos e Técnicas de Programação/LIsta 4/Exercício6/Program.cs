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
            int opcao;
            double n1, n2;

            Console.WriteLine("\nMenu\r\n1. Converter de Celsius para Fahrenheit\r\n2. Converter de Celsius para Kelvin\r\n3. Converter de Fahrenheit para Celsius\r\n4. Converter de Fahrenheit para Kelvin\r\n5. Converter de Kelvin para Celsius\r\n6. Converter de Kelvin para Fahrenheit\r\n7. Sair");

            Console.Write("Digite o que deseja executar: ");
            opcao = int.Parse(Console.ReadLine());


            if (opcao >= 1 && opcao <= 7)
            {
                do
                {
                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor em Celsius para converter para Fahrenheit: ");
                        n1 = double.Parse(Console.ReadLine());

                        double CforF = n1 * 1.8 + 32.0;

                        Console.WriteLine(CforF);
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Digite o valor em Celsius para converter para Kelvin: ");
                        n1 = double.Parse(Console.ReadLine());

                        double CforK = n1 + 273.0;

                        Console.WriteLine(CforK);
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Digite o valor em Fahrenheit para converter para Celsius: ");
                        n1 = double.Parse(Console.ReadLine());

                        double FforC = (n1 - 32) / 1.8;

                        Console.WriteLine(FforC);
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine("Digite o valor em Fahrenheit para converter para Kelvin: ");
                        n1 = double.Parse(Console.ReadLine());

                        double FforK = (n1 - 32) * (5 / 9) + 273.0;

                        Console.WriteLine(FforK);
                    }
                    else if (opcao == 5)
                    {
                        Console.WriteLine("Digite o valor em Kelvin para converter para Celsius: ");
                        n1 = double.Parse(Console.ReadLine());

                        double KforC = n1 - 273.0;

                        Console.WriteLine(KforC);
                    }
                    else if (opcao == 6)
                    {
                        Console.WriteLine("Digite o valor em Kelvin para converter para Fahrenheit: ");
                        n1 = double.Parse(Console.ReadLine());

                        double KforF = (n1 - 273.0) * 1.8 + 32;

                        Console.WriteLine(KforF);
                    }
                    Console.Write("Digite o que deseja executar: ");
                    opcao = int.Parse(Console.ReadLine());

                } while (opcao != 7);

                               
            }
            else
            {
                Console.WriteLine("Opção inválida");

            }

            Console.ReadLine();
        }
    }
}
