using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de pessoas que deseja ler a idade: ");
            int quantidadePessoas = int.Parse(Console.ReadLine());

            int contador = 1, cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0;

            while (contador <= quantidadePessoas) 
            {
                Console.WriteLine("Digite a idade ");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 1 && idade <= 15){
                    cont1++;
                }
                else if (idade >= 16 && idade <= 30)
                {
                    cont2++;
                }
                else if (idade >= 31 && idade <= 55)
                {
                    cont3++;
                }
                else if (idade >= 46 && idade < 61)
                {
                    cont4++;
                }
                else if (idade > 61)
                {
                    cont5++;
                }

                contador++;
            }

            Console.WriteLine("1 a 15 anos = " + cont1 + ", percentual sobre o total: " + ((cont1*100)/quantidadePessoas) + "%");
            Console.WriteLine("\r\n16 a 30 anos = " + cont2 + ", percentual sobre o total:  " + ((cont2 * 100) / quantidadePessoas) + "%");
            Console.WriteLine("\r\n31 a 45 anos = " + cont3 + ", percentual sobre o total: " + ((cont3 * 100) / quantidadePessoas) + "%");
            Console.WriteLine("\r\n46 a 60 anos = " + cont4 + ", percentual sobre o total: " + ((cont4 * 100) / quantidadePessoas) + "%");
            Console.WriteLine("\r\n> ou = 61 anos = " + cont5 + ", percentual sobre o total: " + ((cont5 * 100) / quantidadePessoas) + "%");
            Console.ReadLine();
        }
    }
}

