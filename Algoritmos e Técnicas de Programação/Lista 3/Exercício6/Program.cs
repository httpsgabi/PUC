using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char resposta;
            float salario, maiorSalario = 0, mediaSalario = 0, mediaAnosEstudados = 0, salarioMenorQue = 0, estudoMaiorQue = 0;
            int tempoEstudo, contadorPessoas = 0;


            Console.WriteLine("Obetenha resultados da pesquisa da cidade Melhor de Minas");
            Console.Write("Digite 's' se deseja informar os dados de um habitante e 'n' para não: ");
            resposta = char.Parse(Console.ReadLine()); 

            while(resposta == 'S' || resposta == 's'){
                Console.Write("\nDigite o salário do habitante: ");
                salario = float.Parse(Console.ReadLine());
                Console.Write("\nDigite o tempo de estudo do habitante: ");
                tempoEstudo = int.Parse(Console.ReadLine());

                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }

                if (salario <= 5000)
                {
                    salarioMenorQue++;
                }
                if (estudoMaiorQue >= 15)
                {
                    estudoMaiorQue++;
                }

                mediaSalario = mediaSalario + salario;
                mediaAnosEstudados = mediaAnosEstudados + tempoEstudo;

                Console.WriteLine("--------------------------------------------------------");
                Console.Write("\nDeseja informar um novo habitante, digite 's' para sim e 'n' para obter os dados finais?: ");
                resposta = char.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------");

                contadorPessoas++;
            }

            if (contadorPessoas != 0)
            {
                Console.WriteLine("1. média do salário da população: " + mediaSalario / contadorPessoas);
                Console.WriteLine("2. média de anos de estudo: " + mediaAnosEstudados / contadorPessoas);
                Console.WriteLine("3. maior salário: " + maiorSalario);
                Console.WriteLine("4. percentual de pessoas com salário até R$5000,00: " + (100.0 * salarioMenorQue) / contadorPessoas + "%");
                Console.WriteLine("5. percentual de pessoas com 15 ou mais anos de estudo: " + (100.0 * estudoMaiorQue) / contadorPessoas);
            }

            Console.ReadLine();
        }
    }
}
