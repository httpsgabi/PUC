using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Lista1
    {
        int count;
        public Produto[] ListaProdutos;

        public Lista1(int tamanho)
        {
            ListaProdutos = new Produto[tamanho];
            count = 0;
        }

        public void InserirFinal(Produto produto)
        {
            if (count >= ListaProdutos.Length)
            {
                throw new Exception("Erro");
            }

            ListaProdutos[count] = produto;
            count++;
        }

        public Produto RemoverItem(string nome)
        {
            bool contem = false;
            int count2 = 0;

            Produto produto = null;
           

            if (count == 0)
            {
                throw new Exception("Erro");
            }

            for (int i = 0; i <= count && contem != true; i++)
            {
                if (nome.Equals(ListaProdutos[i].Nome))
                {
                    contem = true;
                    produto = ListaProdutos[i];
                    count2 = i;
                }
            }

            for (int i = count2; i < count - 1; i++)
            {
                ListaProdutos[i] = ListaProdutos[i + 1];
            }

            count--;

            return produto;
        }

        public void Listar()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{ListaProdutos[i].ToString()}");
            }
        }

        public bool Pesquisar(string nome)
        {
            bool contem = false;

            for (int i = 0; i < count && contem == false; i++)
            {
                if (nome == ListaProdutos[i].Nome)
                {
                    contem = true;
                }
            }

            return contem;
        }
    }
}