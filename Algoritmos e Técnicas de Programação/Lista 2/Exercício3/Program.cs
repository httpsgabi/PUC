using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veja se você está apto para a habilitação na categoria D.\r\nDigite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18) {
                Console.WriteLine("Você não está apto para qualquer tipo de habilitação");
            }
            else {
                Console.WriteLine("Digite o tipo da habilitação: ");
                char tipoHabilitacao = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite o tempo de sua habilitação");
                int tempoHabilitado = int.Parse(Console.ReadLine());

                if (idade >= 21)
                {
                    if (tipoHabilitacao == 'A' || tipoHabilitacao == 'a')
                    {
                        Console.WriteLine("Você não está habilitado para a carteira D, os requisitos são: ");
                        Console.WriteLine("1. Ter 21 anos completos;\r\n2. Estar habilitado no mínimo há 2 anos na categoria B ou 1 ano na categoria C.");
                    }
                    else if (tipoHabilitacao == 'B' || tipoHabilitacao == 'b')
                    {
                        if(tempoHabilitado < 2)
                        {
                            Console.WriteLine("Você não está habilitado para a carteira D, os requisitos são: ");
                            Console.WriteLine("1. Ter 21 anos completos;\r\n2. Estar habilitado no mínimo há 2 anos na categoria B ou 1 ano na categoria C.");
                        }
                        else
                        {
                            Console.WriteLine("Você está apto para o tipo de habilitação D!");
                        }
                    }
                    else if (tipoHabilitacao == 'C' || tipoHabilitacao == 'c')
                    {
                        if (tempoHabilitado < 1)
                        {
                            Console.WriteLine("Você não está habilitado para a carteira D, os requisitos são: ");
                            Console.WriteLine("1. Ter 21 anos completos;\r\n2. Estar habilitado no mínimo há 2 anos na categoria B ou 1 ano na categoria C.");
                        }
                        else
                        {
                            Console.WriteLine("Você está apto para o tipo de habilitação D!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Você não está habilitado para a carteira D, os requisitos são: ");
                    Console.WriteLine("1. Ter 21 anos completos;\r\n2. Estar habilitado no mínimo há 2 anos na categoria B ou 1 ano na categoria C.");
                }
            }
            
            Console.ReadLine();
        }
    }
}
