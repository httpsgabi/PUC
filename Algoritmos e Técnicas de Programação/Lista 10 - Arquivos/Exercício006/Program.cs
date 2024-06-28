using System;
using System.IO;
using System.Text;

namespace Exercício006
{
    internal class Program
    {
        static void GerarFuncionarios()
        {
            int quantFuncionarios = 100;
            string nomeFuncionario;
            long bytesFuncionario;

            try
            {
                StreamWriter ArqFuncionarios = new StreamWriter("DadosFuncionarios.txt", false, Encoding.UTF8);
                Random rand = new Random();

                for (int i = 0; i < quantFuncionarios; i++)
                {
                    nomeFuncionario = "Funcionario " + i;
                    bytesFuncionario = rand.Next(1000, 900000000);

                    ArqFuncionarios.WriteLine(nomeFuncionario + "/" + bytesFuncionario);
                }
                ArqFuncionarios.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        static void GerarRelatorio()
        {
            string linha;
            long totEspaco = 0;
            string[] temp;
            int count = 0;

            string[] nomesFuncionarios = new string[100];
            long[] bytesFuncionarios = new long[100];
            float porcentagemFunc = 0, porcentagemDisco = 0;

            try
            {
                StreamWriter ArqRelatorio = new StreamWriter("RelatorioFuncionarios.txt", false, Encoding.UTF8);
                StreamReader ArqFuncionarios = new StreamReader("DadosFuncionarios.txt", Encoding.UTF8);

                linha = ArqFuncionarios.ReadLine();

                while (linha != null)
                {
                    temp = linha.Split('/');
                    nomesFuncionarios[count] = temp[0];
                    bytesFuncionarios[count] = long.Parse(temp[1]);

                    totEspaco += bytesFuncionarios[count];
                    porcentagemFunc = (float)(100 * bytesFuncionarios[count]) / 53687091200;

                    Console.WriteLine($"A porcentagem do {nomesFuncionarios[count]} no disco é: {porcentagemFunc}");

                    linha = ArqFuncionarios.ReadLine();
                    count++;
                }

                ArqRelatorio.Close();
                ArqFuncionarios.Close();

                porcentagemDisco = (100 * totEspaco) / 53687091200;

                Console.WriteLine($"O espaço total ocupado no disco é: {totEspaco}, e a porcentagem no disco é: {Math.Round(porcentagemDisco, 2)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            GerarFuncionarios();
            GerarRelatorio();

            Console.ReadLine();
        }
    }
}
