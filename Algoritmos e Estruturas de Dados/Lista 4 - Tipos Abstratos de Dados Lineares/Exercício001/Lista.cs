using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Lista1
    {
        private double[] lista;
        private int count;
        public Lista1(int tamanho)
        {
            lista = new double[tamanho];
            count = 0;
        }
        public void InserirInicio(double x)
        {

            if (count >= lista.Length)
            {
                throw new Exception("Erro! InserirInicio");
            }

            for (int i = count; i > 0; i--)
            {
                lista[i] = lista[i - 1];
            }

            lista[0] = x;
            count++;
        }
        public void InserirFim(double x)
        {
            if (count >= lista.Length)
            {
                throw new Exception("Erro! InserirFim");
            }

            lista[count] = x;
            count++;
        }
        public void Inserir(double x, int pos)
        {
            if (count >= lista.Length || pos < 0 || pos > count)
            {
                throw new Exception("Erro! Inserir");
            }

            for (int i = count; i > pos; i--)
            {
                lista[i] = lista[i - 1];
            }

            lista[pos] = x;
            count++;
        }
        public double RemoverInicio()
        {
            if (count == 0)
            {
                throw new Exception("Erro, lista vazia");
            }

            double resp = lista[0];
            count--;

            for (int i = 0; i < count; i++)
            {
                lista[i] = lista[i + 1];
            }

            return resp;
        }
        public double RemoverFim()
        {
            if (count == 0)
            {
                throw new Exception("Erro, lista vazia");
            }

            count--;
            return lista[count];
        }
        public double Remover(int pos)
        {
            if (count == 0 || pos < 0 || pos >= count)
            {
                throw new Exception("Erro! Lista vazia ou posição inválida");
            }

            double resp = lista[pos];
            count--;

            for (int i = pos; i < count; i++)
            {
                lista[i] = lista[i + i];
            }

            return resp;
        }

        public int Contar(double x)
        {
            int resp = 0;

            for (int i = 0; i < count; i++)
            {
                if (lista[i] == x)
                {
                    resp++;
                }
            }

            return resp;
        }


        public void RemoverItem(double x)
        {
            int index = -1;

            if (count == 0)
            {
                throw new Exception("Erro! Lista vazia");
            }

            for (int i = 0; i < count; i++)
            {
                if (lista[i] == x)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                throw new Exception("Erro! Item não encontrado.");
            }

            for (int i = index; i < count - 1; i++)
            {
                lista[i] = lista[i + 1];
            }

            count--;
        }

        public void Mostrar()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i}: {lista[i]}");
            }
        }


    }
}
