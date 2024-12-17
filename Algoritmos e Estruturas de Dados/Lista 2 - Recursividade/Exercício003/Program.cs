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
            if(numDecimal == 1)
            { 
                Console.Write(numDecimal % 2);
            }
            else
            {
                Conversor(numDecimal / 2);
                Console.Write(numDecimal % 2);
            }
        }
        static void Main(string[] args)
        {
            Conversor(10);
            Console.ReadLine();
        }
    }
}
