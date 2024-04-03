using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros inteiros e ímpares para imprimir todos o ímpares entre eles, o numero 1 deve obrigatoriamente menor que o 2: ");
            Console.WriteLine("Numero 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2:");
            int num2 = int.Parse(Console.ReadLine());

            int contador = num1;

            if ((num1 % 2 == 0 && num2 % 2 == 0) || (num1 < num2))
            {
                Console.WriteLine("Digite apenas números ímpares e o valor do número 1, deve ser menor que o número 2");
            }
            else
            {
                while (contador >= num1 && contador <= num2)
                {
                    Console.Write(contador + " ");
                    contador = contador + 2;
                };
            }

            Console.ReadLine();
        }
    }
}
