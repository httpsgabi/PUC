using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números para inverter seus valores: ");

            Console.WriteLine("Numero 1: ");
            float varA = float.Parse(Console.ReadLine());

            Console.WriteLine("Numero 2: ");
            float varB = float.Parse(Console.ReadLine());

            Console.WriteLine("Antes da troca: " + varA + " e " + varB);

            float varTemporaria = varA;
            varA = varB;
            varB = varTemporaria;            ;

            Console.WriteLine("Depois da troca:" + varA + " e " + varB);

            Console.ReadLine();


        }
    }
}
