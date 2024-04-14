using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char resposta;
            int countCandidado1 = 0, countCandidado2 = 0, countCandidado3 = 0, countNulo = 0, countBranco = 0, voto;

            Console.Write("Digite 's' se deseja informar um candidadato: ");
            resposta = char.Parse(Console.ReadLine());

            do
            {
                Console.Write("\nDigite o numero do candidato: ");
                voto = int.Parse(Console.ReadLine());

                if (voto >= 1 && voto <= 4)
                {
                    if (voto == 1)
                    {
                        countCandidado1++;
                    }
                    else if (voto == 2){
                        countCandidado2++;
                    }
                    else if(voto == 3)
                    {
                        countCandidado3++;  
                    }
                    else{
                        countBranco++;
                    }
                }
                else
                {
                    countNulo++;
                }

                Console.Write("\nDeseja informar um novo candidadato? ");
                resposta = char.Parse(Console.ReadLine());

            } while (resposta == 's' || resposta == 'S');

            Console.Write("\nCandidato 1: " + countCandidado1 + " votos");
            Console.Write("\nCandidato 2: " + countCandidado2 + " votos");
            Console.Write("\nCandidato 3: " + countCandidado3 + " votos");
            Console.Write("\nVotos Brancos: " + countBranco + " votos");
            Console.Write("\nVotos Nulos: " + countNulo + " votos");

            if (countCandidado1 > countCandidado2 && countCandidado1 > countCandidado3)
            {
                Console.Write("\nCandidato com mais votos: 1");
            }
            else if (countCandidado2 > countCandidado1 && countCandidado2 > countCandidado3)
            {
                Console.Write("\nCandidato com mais votos: 2");

            }
            else if(countCandidado3 > countCandidado1 && countCandidado3 > countCandidado2)
            {
                Console.Write("\nCandidato com mais votos: 3");

            }


            Console.ReadLine();
        }
    }
}
