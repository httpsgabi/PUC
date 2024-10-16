using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício006
{
    internal class ListaSimples
    {
        private Celula primeiro, ultimo;
        public ListaSimples()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }
        public void InserirInicio(Site site)
        {

            Celula tmp = new Celula(site);
            tmp.Prox = primeiro.Prox;
            primeiro.Prox = tmp;

            if (primeiro == ultimo)
            {
                ultimo = tmp;
            }

            tmp = null;
        }
        public void InserirFim(Site site)
        {

            ultimo.Prox = new Celula(site);
            ultimo = ultimo.Prox;
        }
        public void Inserir(Site site, int pos)
        {
            int tamanho = Tamanho();
            if (pos < 0 || pos > tamanho)
            {
                throw new Exception("Erro!");
            }
            else if (pos == 0)
            {
                InserirInicio(site);
            }
            else if (pos == tamanho)
            {
                InserirFim(site);
            }
            else
            {
                Celula i = primeiro;
                for (int j = 0; j < pos; j++, i = i.Prox) ;
                Celula tmp = new Celula(site);
                tmp.Prox = i.Prox;
                i.Prox = tmp;
                tmp = i = null;
            }
        }

        public Site RemoverInicio()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro! Fila, vazia");
            }

            Celula tmp = primeiro;
            primeiro = primeiro.Prox;

            Site siteRemovido = primeiro.Elemento;

            tmp.Prox = null;
            tmp = null;

            return siteRemovido;
        }

        public Site RemoverFim()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro! Fila, vazia");
            }

            Celula i;
            for (i = primeiro; i.Prox != ultimo; i = i.Prox) ;

            Site siteRemovido = ultimo.Elemento;

            ultimo = i;
            i = ultimo.Prox = null;

            return siteRemovido;
        }
        public Site RemoverPos(int pos)
        {

            int tamanho = Tamanho();
            Site siteRemovido;


            if (primeiro == ultimo || pos < 0 || pos >= tamanho)
            {
                throw new Exception("Erro!");
            }

            else if (pos == 0)
            {
                siteRemovido = RemoverInicio();
            }

            else if (pos == tamanho - 1)
            {
                siteRemovido = RemoverFim();
            }

            else
            {
                Celula i = primeiro;
                for (int j = 0; j < pos; j++, i = i.Prox) ;
                Celula tmp = i.Prox;
                siteRemovido = tmp.Elemento; i.Prox = tmp.Prox;
                tmp.Prox = null; i = tmp = null;
            }
            return siteRemovido;
        }

        public Site RemoverItem(Site site)
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro! Fila, vazia");
            }

            Celula anterior = primeiro;
            Celula atual = primeiro.Prox;

            while (atual != null && atual.Elemento != site)
            {
                anterior = atual;
                atual = atual.Prox;
            }

            Site siteRemovido = atual.Elemento;
            anterior.Prox = atual.Prox;


            if (atual == ultimo)
            {
                ultimo = anterior;
            }

            return siteRemovido;

        }
        public void Mostrar()
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.WriteLine($"{i.Elemento.Nome}: {i.Elemento.Link}");
            }
        }

        public int Tamanho()
        {
            int tamanhoLista = 0;

            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                tamanhoLista++;
            }

            return tamanhoLista;
        }

        public string Pesquisar(string nome)
        {
            string linkSite = "";

            for (Celula i = primeiro.Prox; i != null && nome != i.Elemento.Nome; i = i.Prox)
            {
                if (nome == i.Elemento.Nome)
                {
                    linkSite = i.Elemento.Link;
                }
            }
            
            return linkSite;
        }

    }
}
