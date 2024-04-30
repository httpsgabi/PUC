//Exercício 1
using System;


namespace Exercício1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do lado de um quadrado para calcular seu: perímetro, área e diagonal: ");

            int lado = int.Parse(Console.ReadLine());

            int perimetro = lado * 4;
            int area = lado * lado;
            double diagonal = lado * Math.Sqrt(lado);

            Console.WriteLine("Perímetro: " + perimetro);
            Console.WriteLine("Área: " + area);
            Console.WriteLine("Diagonal: " + diagonal);
            Console.ReadLine();
        }
    }
}

