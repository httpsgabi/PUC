using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] votos = new int[100];
            int perso0 = 0, perso1 = 0, perso2 = 0, perso3 = 0, perso4 = 0, votosNulos = 0, maisVotado, menosVotado=0 ;
            string nomeMenosVotado;

            Console.WriteLine("Os personagens são:\n0. Perna Longa\r\n1. Pluto\r\n2. Mickey\r\n3. Bob Esponja\r\n4. Cebolinha\nDigite o numero que deseja para votar");

            for (int i = 0; i < votos.Length; i++)
            {
                Console.Write("\nDigite a nota " + (i + 1) + ": ");
                votos[i] = int.Parse(Console.ReadLine());

                if (votos[i] == 0) {
                    perso0++;
                }
                else if (votos[i] == 1)
                {
                    perso1++;
                }
                else if (votos[i] == 2)
                {
                    perso2++;
                }
                else if (votos[i] == 3)
                {
                    perso3++;
                }
                else if (votos[i] == 4)
                {
                    perso4++;
                }
                else {
                    votosNulos++;
                }
            }

            if (perso0 > perso1 && perso0 > perso2 && perso0 > perso3 && perso0 > perso4)
            {
                Console.WriteLine("O candidado mais votado teve " + perso0 + " votos, e seu numero é 0 ");
            }
            else if (perso1 > perso0 && perso1 > perso2 && perso1 > perso3 && perso1 > perso4)
            {
                Console.WriteLine("O candidado mais votado teve " + perso1 + " votos, e seu numero é 1 ");
            }
            else if (perso2 > perso0 && perso2 > perso1 && perso2 > perso3 && perso2 > perso4)
            {
                Console.WriteLine("O candidado mais votado teve " + perso2 + " votos, e seu numero é 2 ");
            }
            else if (perso3 > perso0 && perso3 > perso1 && perso3 > perso2 && perso3 > perso4)
            {
                Console.WriteLine("O candidado mais votado teve " + perso3 + " votos, e seu numero é 3 ");
            }
            else if (perso4 > perso0 && perso4 > perso1 && perso4 > perso2 && perso4 > perso3)
            {
                Console.WriteLine("O candidado mais votado teve " + perso4 + " votos, e seu numero é 4 ");
            }



            if (perso0 < perso1 && perso0 < perso2 && perso0 < perso3 && perso0 < perso4)
            {
                nomeMenosVotado = "Perna Longa";
                Console.WriteLine("O candidado menos votado teve " + perso0 + " votos, e seu nome é: " + nomeMenosVotado);
            }
            else if (perso1 < perso0 && perso1 < perso2 && perso1 < perso3 && perso1 < perso4)
            {
                nomeMenosVotado = "Pluto";
                Console.WriteLine("O candidado menos votado teve " + perso1 + " votos, e seu nome é: " + nomeMenosVotado);
            }
            else if (perso2 < perso0 && perso2 < perso1 && perso2 < perso3 && perso2 < perso4)
            {
                nomeMenosVotado = "Mickey";
                Console.WriteLine("O candidado menos votado teve " + perso2 + " votos, e seu nome é: " + nomeMenosVotado);
            }
            else if (perso3 < perso0 && perso3 < perso1 && perso3 < perso2 && perso3 < perso4)
            {
                nomeMenosVotado = "Bob Esponja";
                Console.WriteLine("O candidado menos votado teve " + perso3 + " votos, e seu nome é: " + nomeMenosVotado);
            }
            else if (perso4 < perso0 && perso4 < perso1 && perso4 < perso2 && perso4 < perso3)
            {
                nomeMenosVotado = "Cebolinha";
                Console.WriteLine("O candidado menos votado teve " + perso4 + " votos, e seu nome é: " + nomeMenosVotado);
            }

            Console.ReadLine();

        }
    }
}
