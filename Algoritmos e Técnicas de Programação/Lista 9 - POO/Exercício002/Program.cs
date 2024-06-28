using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;

            dia = 10;
            mes = 10;
            ano = 2005;

            Data data1 = new Data(dia, mes, ano);
            Console.WriteLine(data1.ToString());

            dia = 25;
            mes = 12;
            ano = 2023;

            Data data2 = new Data(dia, mes, ano);
            Console.WriteLine(data2.ToString());

            Console.ReadLine();
        }
    }
}
