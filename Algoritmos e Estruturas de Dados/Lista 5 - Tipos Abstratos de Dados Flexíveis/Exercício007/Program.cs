using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercício007
{
    internal class Program
    { 
        static void ExibirMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1)  Inserir uma musica no final da lista");
            Console.WriteLine("2)  Inserir uma musica no inicio da lista");
            Console.WriteLine("3)  Inserir uma musica numa posicao especifica da lista");
            Console.WriteLine("4)  Remover a musica do inicio da lista");
            Console.WriteLine("5)  Remover a musica do final da lista");
            Console.WriteLine("6)  Remover uma musica de uma posicao especifica da lista");
            Console.WriteLine("7)  Remover uma musica especifica");
            Console.WriteLine("8)  Listar todas as musicas da lista");
            Console.WriteLine("9)  Listar todas as musicas da lista na ordem inversa");
            Console.WriteLine("10) Pesquisar uma musica na lista");
            Console.WriteLine("11) Pesquisar musica anterior");
            Console.WriteLine("12) Pesquisar musica posterior");
            Console.WriteLine("13) Encerrar o programa");
        }
        static void Main(string[] args)
        {
            int opcaoMenu, posMusica;
            string nomeMusica;

            ListaDupla listaMusicas = new ListaDupla();

            ExibirMenu();
            opcaoMenu = int.Parse(Console.ReadLine());

            while (opcaoMenu != 13)
            {
                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine("Informe a musica");
                        nomeMusica = Console.ReadLine();

                        listaMusicas.InserirFim(nomeMusica);

                        break;
                    case 2:

                        Console.WriteLine("Informe a musica");
                        nomeMusica = Console.ReadLine();

                        listaMusicas.InserirInicio(nomeMusica);

                        break;
                    case 3:

                        Console.WriteLine("Informe a musica");
                        nomeMusica = Console.ReadLine();

                        Console.WriteLine("Informe a posicao");
                        posMusica = int.Parse(Console.ReadLine());

                        listaMusicas.Inserir(nomeMusica, posMusica);

                        break;
                    case 4:

                        Console.WriteLine($"Musica removida: {listaMusicas.RemoverInicio()}");

                        break;
                    case 5:

                        Console.WriteLine($"Musica removida: {listaMusicas.RemoverFim()}");

                        break;
                    case 6:

                        Console.WriteLine("Informe a posicao");
                        posMusica = int.Parse(Console.ReadLine()) ;

                        Console.WriteLine($"Musica removida: {listaMusicas.Remover(posMusica)}");

                        break;
                    case 7:

                        Console.WriteLine("Informe a musica");
                        nomeMusica = Console.ReadLine();

                        listaMusicas.RemoverMusica(nomeMusica);

                        break;
                    case 8:

                        Console.WriteLine("Lista:");
                        listaMusicas.Mostrar();

                        break;
                    case 9:

                        Console.WriteLine("Lista - ordem inversa:");
                        listaMusicas.ListarInverso();

                        break;
                    case 10:

                        Console.WriteLine("Informe a musica");
                        nomeMusica = Console.ReadLine();

                        listaMusicas.PesquisarMusica(nomeMusica);

                        break;
                    case 11:

                        Console.WriteLine("Informe a musica");
                        nomeMusica = Console.ReadLine();

                        listaMusicas.PesquisarAnterior(nomeMusica);

                        break;
                    case 12:
                        Console.WriteLine("");

                        Console.WriteLine("Informe a musica");
                        nomeMusica = Console.ReadLine();
                       
                        listaMusicas.PesquisarPosterior(nomeMusica);

                        break;
                }


                ExibirMenu();
                opcaoMenu = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O programa sera encerrado.");
        }
    }
}

internal class CelulaDupla
{
    private string elemento;
    private CelulaDupla prox;
    private CelulaDupla ant;
    public CelulaDupla(string elemento)
    {
        this.elemento = elemento;
        this.ant = null;
        this.prox = null;
    }
    public CelulaDupla()
    {
        this.elemento = "";
        this.ant = null;
        this.prox = null;
    }
    public CelulaDupla Prox
    {
        get { return prox; }
        set { prox = value; }
    }
    public CelulaDupla Ant
    {
        get { return ant; }
        set { ant = value; }
    }
    public string Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }
}

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
            Console.WriteLine(i.Elemento);;
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

        while (atual != null)
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