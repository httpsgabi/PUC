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
            double[] temperaturas = new double[5];

            double tempDesejada;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine("Digite a temperatura " + i);
                temperaturas[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite qual temperatura você deseja pesquisar: ");
            tempDesejada = double.Parse(Console.ReadLine());

            Console.WriteLine("Os dias com essa temperatura: ");
            for (int j = 0; j < temperaturas.Length; j++)
            {
                if (temperaturas[j] == tempDesejada)
                {
                    Console.WriteLine(j);
                }

            }

            Console.ReadLine();
        }
    }
}
