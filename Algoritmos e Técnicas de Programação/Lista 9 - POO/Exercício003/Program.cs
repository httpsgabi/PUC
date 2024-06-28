using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio1, raio2, raio3;

            raio1 = 10.5;
            Circulo c1 = new Circulo(raio1);
            c1.ImprimeInformacoes();
            Console.WriteLine();

            raio2 = 2.78;
            Circulo c2 = new Circulo(raio2);
            c2.ImprimeInformacoes();
            Console.WriteLine();

            raio3 = 20.46;
            Circulo c3 = new Circulo(raio3);
            c3.ImprimeInformacoes();
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
