using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
{
    internal class Program
    {
        static int CalcMMC(int n1, int n2)
        {
            int mmc = 0;

            if (n1 >= n2)
            {
                for (int i = 1; i < n1; i++)
                {
                    mmc = n1 * i;
                    if (mmc % n2 == 0)
                    {
                        Console.WriteLine($"O MMC de {n1} e {n2} é : {mmc}");
                        break;
                    }
                }
            }
            else if (n2 > n1)
            {
                for (int i = 1; i < n2; i++)
                {
                    mmc = n2 * i;
                    if (mmc % n1 == 0)
                    {
                        Console.WriteLine($"O MMC de {n1} e {n2} é : {mmc}");

                        break;
                    }
                }
            }

            return mmc;
        }

        static int CalcMDC(int n1, int n2, int n3)
        {
            int mdc = 0, count = 1;
            bool minDivisor = false;

            if (n1 > n2 && n1 > n3)
            {
                count = n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                count = n2;
            }
            else if (n3 > n1 && n3 > n2) // Corrigindo a condição aqui
            {
                count = n3;
            }

            while (count > 0) // Corrigindo a condição aqui
            {
                if (n1 % count == 0 && n2 % count == 0 && n3 % count == 0)
                {
                    mdc = count;
                }
                else
                {
                    count--;
                }
            }

            Console.WriteLine($"O MDC de {n1}, {n2} e {n3} é : {mdc}");

            return mdc;
        }

        static void Main(string[] args)
        {
            int opcao = 0, n1, n2, n3, mmc, mdc;

            while (opcao != 3)
            {

                Console.Write($"\n\nDigite a opção que deseja realizar: ");
                Console.WriteLine("\n1) Calcular MMC\r\n2) Calcular MDC\r\n3) Sair do programa");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("\nDigite o numero 1: ");
                    n1 = int.Parse(Console.ReadLine());

                    Console.Write("\nDigite o numero 2: ");
                    n2 = int.Parse(Console.ReadLine());

                    mmc = CalcMMC(n1, n2);
                }
                else if (opcao == 2)
                {
                    Console.Write("\nDigite o numero 1: ");
                    n1 = int.Parse(Console.ReadLine());

                    Console.Write("\nDigite o numero 2: ");
                    n2 = int.Parse(Console.ReadLine());

                    Console.Write("\nDigite o numero 3: ");
                    n3 = int.Parse(Console.ReadLine());

                    mdc = CalcMDC(n1, n2, n3);
                }
            }

            Console.ReadLine();
        }
    }
}
