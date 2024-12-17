using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class ArvoreBinaria
    {
        private No raiz;

        public ArvoreBinaria()
        {
            raiz = null;
        }

        //Métodos de Inserção
        public void Inserir(int x) {
            raiz = Inserir(x, raiz);
        }

        private No Inserir(int x, No i)
        {
            if (i == null)
            {
                i = new No(x);
            }
            else if(x < i.Elemento)
            {
                i.Esq = Inserir(x, i.Esq);
            }
            else if (x > i.Elemento)
            {
                i.Dir = Inserir(x, i.Dir);
            }
            else
            {
                throw new Exception("Erro!");
            }

            return i;
        }

        //Métodos de Pesquisa
        public bool Pesquisar(int x) {
            return Pesquisar(x, raiz);
        }

        private bool Pesquisar(int x, No i)
        {
            bool resp;

            if (i == null)
            {
                resp = false;
            }
            else if(x == i.Elemento)
            {
                resp = true;
            }
            else if(x < i.Elemento)
            {
                resp = Pesquisar(x, i.Esq);
            }
            else
            {
                resp = Pesquisar(x, i.Dir);
            }

            return resp;
        }

        //Métodos de Caminhamento Central
        public void CaminharCentral() {
            CaminharCentral(raiz);
        }

        private void CaminharCentral(No i)
        {
            if (i != null)
            {
                CaminharCentral(i.Esq);
                Console.Write(i.Elemento + " ");
                CaminharCentral(i.Dir);
            }
        }

        //Métodos de Caminhamento Pre Ordem
        public void CaminharPre() { 
            CaminharPre(raiz);
        }
        private void CaminharPre(No i)
        {
            if (i != null)
            {
                Console.Write(i.Elemento +" ");
                CaminharPre(i.Esq);
                CaminharPre(i.Dir);
            }
        }

        //Métodos de Caminhamento Pos Ordem
        public void CaminharPos() {
            CaminharPos(raiz);
        }
        private void CaminharPos(No i)
        {
            if (i != null)
            {
                CaminharPos(i.Esq);
                CaminharPos(i.Dir);
                Console.Write(i.Elemento +"");
            }
        }

        //Método de Remoção
        public void Remover(int x) { 
        
        }

        //Métodos adicionais para obter o maior elemento e o menor
        public int GetMaior()
        {

        }
        public int GetMaior()
        {

        } 
    }
}
