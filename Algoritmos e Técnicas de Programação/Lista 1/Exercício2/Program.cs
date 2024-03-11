//Exercício 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base e a altura do retângulo para calcular seu perímetro, área e diagonal: ");

            int baseTriangulo = int.Parse(Console.ReadLine());
            int alturaTriangulo = int.Parse(Console.ReadLine());

            int perimetro = 2 * (baseTriangulo * alturaTriangulo);
            int area = baseTriangulo * alturaTriangulo;
            double diagonal = Math.Sqrt((baseTriangulo ^ 2) + (alturaTriangulo ^ 2));

            Console.WriteLine("Perímetro: " + perimetro);
            Console.WriteLine("Área: " + area);
            Console.WriteLine("Diagonal: " + diagonal);
            Console.ReadLine();
        }
    }
}
