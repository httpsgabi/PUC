using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o sexo (F ou M) e a altura de uma pessoa para ter seu peso ideal: ");
            string sexo = Console.ReadLine();
            float altura = float.Parse(Console.ReadLine());
            double pesoIdeal;

            double ehMulher ;
            ehMulher = (sexo == "F" || sexo == "f") ? pesoIdeal = (62.1 * altura) - 44.7 : pesoIdeal = (72.7 * altura) - 58; 
            
            Console.WriteLine("O peso ideal é: "+ pesoIdeal);

            Console.ReadLine();
        }
    }
}
