using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Program
    {
        static double CalcMedia(int num1, int num2, int num3, char letra)
        {
            double media = 0;

            if (letra == 'A' || letra == 'a')
            {
                media = (num1 + num2 + num3) / 3;
            }
            else if (letra == 'P' || letra == 'p')
            {
                media = (num1*5 + num2*3 + num3*2) / (5.0 + 3 + 2);
            }
            else 
            {
                Console.WriteLine("Não foi possível fazer nenhum cálculo, letra inválida, tente novamente!");
            }

            return media;
        }

        static void Main(string[] args)
        {
            int num1, num2, num3;
            char letra;
            double media;

            Console.WriteLine($"Digite três números, e a letra 'A' para calcular a média aritmética ou a letra 'P' para a média ponderada: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a letra: ");
            letra = char.Parse(Console.ReadLine());


            media = CalcMedia(num1, num2, num3, letra);
            Console.WriteLine($"A média é: {Math.Round(media, 2)}");

            Console.ReadLine();
        }
    }
}
