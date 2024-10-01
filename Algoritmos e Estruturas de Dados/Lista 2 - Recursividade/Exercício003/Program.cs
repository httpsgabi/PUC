using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
{
    internal class Program
    {
        static void Conversor(int numDecimal)
        {
            if (numDecimal >= 2)
            {
                Conversor(numDecimal / 2);
            }

            Console.Write(numDecimal % 2);
        }
        static void Main(string[] args)
        {
            int numDecimal;

            Console.WriteLine("Digite o numero decimal para convertê-lo para binário");

            numDecimal = int.Parse(Console.ReadLine());

            Conversor(numDecimal);

            Console.ReadLine();
        }
    }
}
