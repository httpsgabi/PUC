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

            Console.WriteLine("1. Novo salário\r\n2. Férias\r\n3. Décimo terceiro\r\n4. Sair");
            Console.Write("Digite a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("\n---------------------------------------");


            if (opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4)
            {
                while (opcao != 4)
                {
                    Console.WriteLine("\nDigite o salário do funcionário. Atenção, deve ser diferente de 0! ");
                    float salario = float.Parse(Console.ReadLine());

                    if (salario != 0)
                    {
                        if (opcao == 1)
                        {
                            if (salario < 1000)
                            {
                                double novoSalario = salario + (salario * 0.15);
                                Console.Write("O novo salário é de: " + novoSalario);
                            }
                            else if (salario > 1000 && salario <= 2000)
                            {
                                double novoSalario = salario + (salario * 0.1);
                                Console.Write("O novo salário é de: " + novoSalario);
                            }
                            else
                            {
                                double novoSalario = salario + (salario * 0.05);
                                Console.Write("O novo salário é de: " + novoSalario);
                            }
                        }
                        else if (opcao == 2)
                        {
                            double ferias = salario + (salario / 3);
                            Console.Write("O valor das férias é de: " + ferias);
                        }
                        else if (opcao == 3)
                        {
                            Console.WriteLine("Digite a quantidade de meses trabalhados: ");
                            int mesesTrabalhados = int.Parse(Console.ReadLine());
                            if (mesesTrabalhados <= 12)
                            {
                                double decimoTerceiro = (salario * mesesTrabalhados) / 12;
                                Console.Write("O valor do décimo terceiro é de: " + decimoTerceiro);
                            }
                            else
                            {
                                Console.WriteLine("Um funcionário pode ter no máximo 12 meses trabalhados!");
                            }

                            
                        }

                        Console.WriteLine("\n\n---------------------------------------");
                        Console.WriteLine("1. Novo salário\r\n2. Férias\r\n3. Décimo terceiro\r\n4. Sair");
                        Console.Write("Digite a opção desejada: ");
                        opcao = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n---------------------------------------\n");
                    }

                }

            }
            else {
                Console.WriteLine("Opção inválida");
            }

            Console.ReadLine();
        }
    }
}
