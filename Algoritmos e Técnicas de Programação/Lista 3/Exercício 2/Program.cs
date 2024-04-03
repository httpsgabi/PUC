using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores pluviométricos de 31 dias para obter o índice pluviométrico médio, o índice pluviométrico máximo e o dia que ele ocorreu ");

            int contador = 1;
            double indicePluviometrico = 0;
            double indiceMaximo = 0;
            int diaIndiceMaximo = 0;

            while (contador <= 31)
            {
                Console.WriteLine("Dia " + contador);
                double dia = double.Parse(Console.ReadLine());

                indicePluviometrico = indicePluviometrico + dia;

                if (dia > indiceMaximo)
                {
                    indiceMaximo = dia;
                    diaIndiceMaximo = contador;
                }

                contador++;
            }

            double indiceMedio = indicePluviometrico / 31;
            Console.WriteLine("O índice pluviométrico médio é: " + indiceMedio + "m²");
            Console.WriteLine("O índice máximo é: " + indiceMaximo + " e seu dia foi o: " + diaIndiceMaximo);

            Console.ReadLine();
        }
    }
}

