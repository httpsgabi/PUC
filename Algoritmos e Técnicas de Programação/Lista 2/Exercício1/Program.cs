using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade de 3 pessoas para saber qual é a maior e qual é a menor: ");

            int idade1 = int.Parse(Console.ReadLine());
            int idade2 = int.Parse(Console.ReadLine());
            int idade3 = int.Parse(Console.ReadLine());

            if (idade1 == idade2 && idade2 == idade3)
            {
                Console.WriteLine("As tres idades são iguais");
            }
            else if (idade1 > idade2 && idade1 > idade3)
            {
                Console.WriteLine("A primeira idade é a mais velha");
                if (idade2 < idade3)
                {
                    Console.WriteLine("A segunda idade é a mais nova");
                }
                else if (idade2 > idade3)
                {
                    Console.WriteLine("A terceira idade é a mais nova");
                }
            }
            else if (idade2 > idade1 && idade2 > idade3)
            {
                Console.WriteLine("A segunda idade é a mais velha");
                if (idade1 < idade3)
                {
                    Console.WriteLine("A primeira idade é a mais nova");
                }
                else if (idade1 > idade3)
                {
                    Console.WriteLine("A terceira idade é a mais nova");
                }
            }
            else if (idade3 > idade1 && idade3 > idade2)
            {
                Console.WriteLine("A terceira idade é a mais velha");
                if (idade1 < idade2)
                {
                    Console.WriteLine("A primeira idade é a mais nova");
                }
                else if (idade1 > idade2)
                {
                    Console.WriteLine("A segunda idade é a mais nova");
                }
            }

            Console.ReadLine();
        }
    }
}
