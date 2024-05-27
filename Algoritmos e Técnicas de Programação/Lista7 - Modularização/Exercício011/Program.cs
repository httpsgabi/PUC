using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício011
{
    internal class Program
    {
        static void ConverterSegundos(int totalSegundos, out int hora, out int min, out int seg)
        {
            hora = totalSegundos / 3600;
            min = (totalSegundos % 3600) / 60;
            seg = totalSegundos % 60;

        }
        static void Main(string[] args)
        {
            int totalSegundos;

            Console.WriteLine("Digite a quantidade total de segundos: ");
            totalSegundos = int.Parse(Console.ReadLine());

            ConverterSegundos(totalSegundos, out int hora, out int min, out int seg);
            Console.WriteLine($"A quantidade em HH:MM:SS é de: {hora}:{min}:{seg}");

            Console.ReadLine();
        }
    }
}
