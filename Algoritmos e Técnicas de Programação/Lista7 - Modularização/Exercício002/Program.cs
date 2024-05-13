using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Program
    {
        static double CalcHipotenusa(double catetoA, double catetoB)
        {
            double somaCatetos = Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2);
            double hipotenusa = Math.Sqrt(somaCatetos);

            return hipotenusa;
        }
        static void Main(string[] args)
        {
            double catetoA, catetoB, hipotenusa;

            Console.Write("Digite um dos catetos: ");
            catetoA = double.Parse(Console.ReadLine());

            Console.Write("Digite o outro cateto: ");
            catetoB = double.Parse(Console.ReadLine());

            hipotenusa = CalcHipotenusa(catetoA, catetoB);

            Console.Write($"\nA hipotenusa é: {Math.Round(hipotenusa, 2)}");

            Console.ReadLine();

        }
    }
}
