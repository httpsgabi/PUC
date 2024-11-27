using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercício007
{
    internal class ListaDupla
    {
        private CelulaDupla primeiro, ultimo;
        public ListaDupla()
        {
            primeiro = new CelulaDupla();
            ultimo = primeiro;
        }

        public void InserirInicio(string musica)
        {
            CelulaDupla tmp = new CelulaDupla(musica);

            tmp.Ant = primeiro;
            tmp.Prox = primeiro.Prox;

            primeiro.Prox = tmp;

            if (primeiro == ultimo)
            {
                ultimo = tmp;
            }
            else
            {
                tmp.Prox.Ant = tmp;
            }
            tmp = null;
        }

        public void InserirFim(string musica)
        {
            ultimo.Prox = new CelulaDupla(musica);
            ultimo.Prox.Ant = ultimo;
            ultimo = ultimo.Prox;
        }

        public string RemoverInicio()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro!");
            }

            CelulaDupla tmp = primeiro;
            primeiro = primeiro.Prox;

            string elemento = primeiro.Elemento;

            tmp.Prox = primeiro.Ant = null;
            tmp = null;

            return elemento;
        }

        public string RemoverFim()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro!");
            }

            string elemento = ultimo.Elemento;

            ultimo = ultimo.Ant;
            ultimo.Prox.Ant = null;
            ultimo.Prox = null;

            return elemento;
        }

        public void Inserir(string musica, int pos)
        {
            int tamanho = Tamanho();
            if (pos < 0 || pos > tamanho)
            {
                throw new Exception("Erro!");
            }
            else if (pos == 0)
            {
                InserirInicio(musica);
            }
            else if (pos == tamanho)
            {
                InserirFim(musica);
            }
            else
            {
                CelulaDupla i = primeiro;

                for (int j = 0; j < pos; j++, i = i.Prox) ;

                CelulaDupla tmp = new CelulaDupla(musica);

                tmp.Ant = i;
                tmp.Prox = i.Prox;
                tmp.Ant.Prox = tmp.Prox.Ant = tmp;

                tmp = i = null;
            }
        }

        public string Remover(int pos)
        {
            int tamanho = Tamanho();
            string elemento;

            if (primeiro == ultimo)
            {
                throw new Exception("Erro!");
            }
            else if (pos < 0 || pos >= tamanho)
            {
                throw new Exception("Erro!");
            }
            else if (pos == 0)
            {
                elemento = RemoverInicio();
            }
            else if (pos == tamanho - 1)
            {
                elemento = RemoverFim();
            }
            else
            {
                CelulaDupla i = primeiro.Prox;

                for (int j = 0; j < pos; j++, i = i.Prox) ;

                i.Ant.Prox = i.Prox;
                i.Prox.Ant = i.Ant;

                elemento = i.Elemento;
                i.Prox = i.Ant = null;
                i = null;
            }
            return elemento;
        }

        public void Mostrar()
        {
            for (CelulaDupla i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.WriteLine(i.Elemento); ;
            }

        }

        public int Tamanho()
        {
            int tamanhoLista = 0;

            for (CelulaDupla i = primeiro.Prox; i != null; i = i.Prox)
            {
                tamanhoLista++;
            }

            return tamanhoLista;
        }
        public void ListarInverso()
        {
            CelulaDupla atual = ultimo;

            while (atual != primeiro)
            {
                Console.WriteLine(atual.Elemento);
                atual = atual.Ant;
            }
        }
        public void PesquisarMusica(string nome)
        {
            CelulaDupla atual = primeiro;
            while (atual != null)
            {
                if (atual.Elemento.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"A musica esta na lista");
                    return;
                }
                atual = atual.Prox;
            }
            Console.WriteLine($"A musica não consta na lista");
        }

        public void PesquisarAnterior(string nome)
        {
            CelulaDupla atual = primeiro;
            while (atual != null)
            {
                if (atual.Elemento.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    if (atual.Ant != null)
                    {
                        Console.WriteLine($"Musica anterior: {atual.Ant.Elemento}");
                    }
                    else
                    {
                        Console.WriteLine("Não ha musica anterior");
                    }
                    return;
                }
                atual = atual.Prox;
            }
        }

        public void PesquisarPosterior(string nome)
        {
            CelulaDupla atual = primeiro;
            while (atual != null)
            {
                if (atual.Elemento.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    if (atual.Prox != null)
                    {
                        Console.WriteLine($"Mssica posterior: {atual.Prox.Elemento}");
                    }
                    else
                    {
                        Console.WriteLine("Não ha musica posterior");
                    }
                    return;
                }
                atual = atual.Prox;
            }
        }
        public void RemoverMusica(string nome)
        {
            CelulaDupla atual = primeiro;
            while (atual != null)
            {
                if (atual.Elemento.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    if (atual.Ant != null)
                    {
                        atual.Ant.Prox = atual.Prox;
                    }
                    else
                    {
                        primeiro = atual.Prox;
                    }

                    if (atual.Prox != null)
                    {
                        atual.Prox.Ant = atual.Ant;
                    }
                    else
                    {
                        ultimo = atual.Ant;
                    }

                    Console.WriteLine($"Musica {nome} removida");
                    return;
                }
                atual = atual.Prox;
            }
            Console.WriteLine($"Mssica {nome} não encontrada");
        }
    }
}
