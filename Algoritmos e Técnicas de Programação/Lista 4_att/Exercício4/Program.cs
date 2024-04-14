using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float tempDiaria, tempMaxima = 0, tempMinima = 100*100, diaTempMaxima = 0, diaTempMinima = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Temperatura média dia " + i + ": ");
                tempDiaria = int.Parse(Console.ReadLine());

                if (tempDiaria > tempMaxima)
                {
                    tempMaxima = tempDiaria;
                    diaTempMaxima = i;
                }
                if (tempMinima > tempDiaria)
                {
                    tempMinima = tempDiaria;
                    diaTempMinima = i;
                }
            }

            Console.WriteLine("\n---------------------------------------------------");
            Console.WriteLine("Temperatura máxima e seu dia de ocorrência: " + tempMaxima + " - " + diaTempMaxima);
            Console.WriteLine("Temperatura mínima e seu dia de ocorrência: " + tempMinima + " - " + diaTempMinima);

            Console.ReadLine();
        }
    }
}
