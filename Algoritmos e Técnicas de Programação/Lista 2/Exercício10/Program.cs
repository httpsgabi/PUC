using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um tipo de conversão:\r\n1. Converter de centímetros para metros\r\n2. Converter de metros para centímetros\r\n3. Converter de milímetros para metros\r\n4. Converter de metros para milímetros");
            int opcaoMenu = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero: ");

            switch (opcaoMenu)
            {
                case 1:
                    float centimetrosPMetros = float.Parse(Console.ReadLine());
                    float resultado1 = centimetrosPMetros / 100;
                    Console.WriteLine("Resultado: " + resultado1);
                    break;
                case 2:
                    float metrosPCentimetros = float.Parse(Console.ReadLine());
                    float resultado2 = metrosPCentimetros * 100;
                    Console.WriteLine("Resultado: " + resultado2);
                    break;
                case 3:
                    float milimetrosPmetros = float.Parse(Console.ReadLine());
                    float resultado3 = milimetrosPmetros / 100;
                    Console.WriteLine("Resultado: " + resultado3);
                    break;
                case 4:
                    float metrosPmilimetros = float.Parse(Console.ReadLine());
                    float resultado4 = metrosPmilimetros * 100;
                    Console.WriteLine("Resultado: " + resultado4);
                    break;
                default:
                    Console.WriteLine("Número inválido");
                    break;
            }

            Console.ReadLine();
        }
    }
}
