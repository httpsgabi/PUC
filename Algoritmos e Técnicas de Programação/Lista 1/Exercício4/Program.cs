using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de eleitores do município: ");
            int quantidadeEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos brancos, nulos, e válidos: ");

            Console.WriteLine("Brancos: ");
            int votosBrancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Nulos: ");
            int votosNulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Válidos: ");
            int votosValidos = int.Parse(Console.ReadLine());

            int percentualBrancos = (100 * votosBrancos) / quantidadeEleitores;

            int percentualNulos = (100 * votosNulos) / quantidadeEleitores;

            int percentualValidos = (100 * votosValidos) / quantidadeEleitores;

            Console.WriteLine("O percentual de votos é: " + percentualBrancos + "% de votos brancos, "+percentualNulos+ "% de votos nulos, e "+percentualValidos+"% de votos válidos");

            Console.ReadLine();
        }
    }
}
