using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, count = 0, anterior = -2, sequencia = 0;

            Console.WriteLine("Digite os números que deseja e digite -1 para parar");
            num = int.Parse(Console.ReadLine());

            while (num != -1) {

                if (anterior < num)
                {
                    count++;
                }
                else
                {
                    if (count > sequencia)
                    {
                        sequencia = count;
                    }

                    count = 1;
                }

                anterior = num;

                Console.WriteLine("Digite outro número: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A maior sequencia foi de: {sequencia}");
            Console.ReadLine();
        }
    }
}
