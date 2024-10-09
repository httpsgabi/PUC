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

        public int RemoverItem(string nome)
        {
            bool contem = false;
            int count2 = 0;

           
            if (ListaProdutos.Length > count)
            {
                throw new Exception("Erro");
            }

            while (count2 <= count || contem != true)
            {
                if (nome.Equals(ListaProdutos[count2].Nome))
                {
                    contem = true;
                }

                count2++;
            }

            Produto produto = new Produto();


            produto.Nome = ListaProdutos[count2 - 1].Nome;
            produto.Quant = ListaProdutos[count2 - 1].Quant;
            produto.Preco = ListaProdutos[count2 - 1].Preco;


            for (int i = count2 - 1; i < ListaProdutos.Length; i++)
            {
                ListaProdutos[i] = ListaProdutos[i + i];
            }

            return produto;
        }

        public void Listar()
        {
            for (int i = 0; i < ListaProdutos.Length; i++)
            {
                Console.WriteLine($"[nome: {ListaProdutos[i].Nome}, quantidade: {ListaProdutos[i].Quant}, preco: {ListaProdutos[i].Preco}]");
            }
        }

        public bool Pesquisar(string nome)
        {
            bool contem = false;
            int count2 = 0;

            while (count2 <= count || contem != true)
            {
                if (nome.Equals(ListaProdutos[count2].Nome))
                {
                    contem = true;
                }

                count2++;
            }
            return contem;
        }
    }
}