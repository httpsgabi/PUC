using System;
using System.Collections.Generic;
using System.IO;

class Jogador
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public string Universidade { get; set; }
    public int AnoNasc { get; set; }
    public string CidadeNasc { get; set; }
    public string EstadoNasc { get; set; }

    public Jogador(int id, string nome, double altura, double peso, string universidade, int anoNasc, string cidadeNasc, string estadoNasc)
    {
        Id = id;
        Nome = nome;
        Altura = altura;
        Peso = peso;
        Universidade = universidade;
        AnoNasc = anoNasc;
        CidadeNasc = cidadeNasc;
        EstadoNasc = estadoNasc;
    }

    public override string ToString()
    {
        return $"{Id}, {Nome}, {Altura}, {Peso}, {Universidade}, {AnoNasc}, {CidadeNasc}, {EstadoNasc}";
    }
}

class Program
{
    static void MergeSort(List<Jogador> jogadores, int esquerda, int direita)
    {
        if (esquerda < direita)
        {
            int meio = (esquerda + direita) / 2;
            MergeSort(jogadores, esquerda, meio);
            MergeSort(jogadores, meio + 1, direita);
            Merge(jogadores, esquerda, meio, direita);
        }
    }

    static void Merge(List<Jogador> jogadores, int esquerda, int meio, int direita)
    {
        int n1 = meio - esquerda + 1;
        int n2 = direita - meio;

        List<Jogador> esquerdaTemp = new List<Jogador>(n1);
        List<Jogador> direitaTemp = new List<Jogador>(n2);

        for (int i = 0; i < n1; i++)
            esquerdaTemp.Add(jogadores[esquerda + i]);
        for (int j = 0; j < n2; j++)
            direitaTemp.Add(jogadores[meio + 1 + j]);

        int k = esquerda, iTemp = 0, jTemp = 0;
        while (iTemp < n1 && jTemp < n2)
        {
            if (ComparaJogadores(esquerdaTemp[iTemp], direitaTemp[jTemp]) <= 0)
            {
                jogadores[k] = esquerdaTemp[iTemp];
                iTemp++;
            }
            else
            {
                jogadores[k] = direitaTemp[jTemp];
                jTemp++;
            }
            k++;
        }

        while (iTemp < n1)
        {
            jogadores[k] = esquerdaTemp[iTemp];
            iTemp++;
            k++;
        }
        while (jTemp < n2)
        {
            jogadores[k] = direitaTemp[jTemp];
            jTemp++;
            k++;
        }
    }

    static int ComparaJogadores(Jogador a, Jogador b)
    {
        if (a.AnoNasc == b.AnoNasc)
        {
            return string.Compare(a.Nome, b.Nome);  
        }
        return a.AnoNasc.CompareTo(b.AnoNasc);  
    }
    static List<Jogador> LerArquivoCSV(string caminho)
    {
        List<Jogador> jogadores = new List<Jogador>();

        try
        {
            string[] linhas = File.ReadAllLines(caminho);
            for (int i = 1; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(',');

                int id = int.Parse(dados[0]);
                string nome = dados[1].Trim();
                double altura = double.Parse(dados[2]);
                double peso = double.Parse(dados[3]);
                string universidade = dados[4];
                int anoNasc = int.Parse(dados[5]);
                string cidadeNasc = dados[6];
                string estadoNasc = dados[7];

                jogadores.Add(new Jogador(id, nome, altura, peso, universidade, anoNasc, cidadeNasc, estadoNasc));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao ler o arquivo: " + ex.Message);
        }

        return jogadores;
    }

    static void Main()
    {
        string caminhoArquivo = "players.csv"; 

        List<Jogador> jogadores = LerArquivoCSV(caminhoArquivo);

        MergeSort(jogadores, 0, jogadores.Count - 1);

        Console.WriteLine("Jogadores ordenados por ano de nascimento (e nome em caso de empate):");
        foreach (var jogador in jogadores)
        {
            Console.WriteLine(jogador);
        }
    }
}