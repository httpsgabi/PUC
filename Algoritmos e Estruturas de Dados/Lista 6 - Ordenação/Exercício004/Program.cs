using System;
using System.Collections.Generic;
using System.IO;

class Pais
{
    public string Nome { get; set; }
    public int Ouro { get; set; }
    public int Prata { get; set; }
    public int Bronze { get; set; }
    public int Total { get; set; }

    public Pais(string nome, int ouro, int prata, int bronze)
    {
        Nome = nome;
        Ouro = ouro;
        Prata = prata;
        Bronze = bronze;
        Total = ouro + prata + bronze;
    }

    public override string ToString()
    {
        return $"{Nome}: {Ouro} Ouro(s), {Prata} Prata(s), {Bronze} Bronze(s), Total: {Total}";
    }
}

class Program
{
    static void MergeSort(List<Pais> paises, int esquerda, int direita)
    {
        if (esquerda < direita)
        {
            int meio = (esquerda + direita) / 2;
            MergeSort(paises, esquerda, meio);
            MergeSort(paises, meio + 1, direita);
            Merge(paises, esquerda, meio, direita);
        }
    }

    static void Merge(List<Pais> paises, int esquerda, int meio, int direita)
    {
        int n1 = meio - esquerda + 1;
        int n2 = direita - meio;

        List<Pais> esquerdaTemp = new List<Pais>(n1);
        List<Pais> direitaTemp = new List<Pais>(n2);

        for (int i = 0; i < n1; i++)
            esquerdaTemp.Add(paises[esquerda + i]);
        for (int j = 0; j < n2; j++)
            direitaTemp.Add(paises[meio + 1 + j]);

        int k = esquerda, iTemp = 0, jTemp = 0;
        while (iTemp < n1 && jTemp < n2)
        {
            if (ComparaPaises(esquerdaTemp[iTemp], direitaTemp[jTemp]) <= 0)
            {
                paises[k] = esquerdaTemp[iTemp];
                iTemp++;
            }
            else
            {
                paises[k] = direitaTemp[jTemp];
                jTemp++;
            }
            k++;
        }
        while (iTemp < n1)
        {
            paises[k] = esquerdaTemp[iTemp];
            iTemp++;
            k++;
        }
        while (jTemp < n2)
        {
            paises[k] = direitaTemp[jTemp];
            jTemp++;
            k++;
        }
    }

    static int ComparaPaises(Pais a, Pais b)
    {
        if (a.Ouro != b.Ouro)
            return b.Ouro.CompareTo(a.Ouro); 

        if (a.Prata != b.Prata)
            return b.Prata.CompareTo(a.Prata); 
        if (a.Bronze != b.Bronze)
            return b.Bronze.CompareTo(a.Bronze);

        return string.Compare(a.Nome, b.Nome);  
    }

    static List<Pais> LerArquivo(string caminho)
    {
        List<Pais> paises = new List<Pais>();
        try
        {
            string[] linhas = File.ReadAllLines(caminho);
            for (int i = 0; i < linhas.Length; i += 5)
            {
                string nome = linhas[i];
                int ouro = int.Parse(linhas[i + 1]);
                int prata = int.Parse(linhas[i + 2]);
                int bronze = int.Parse(linhas[i + 3]);

                paises.Add(new Pais(nome, ouro, prata, bronze));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao ler o arquivo: " + ex.Message);
        }

        return paises;
    }

    static void Main()
    {
        string caminhoArquivo = "olimpiadas.txt"; 

        List<Pais> paises = LerArquivo(caminhoArquivo);

        MergeSort(paises, 0, paises.Count - 1);

        Console.WriteLine("Quadro de Medalhas - Olimpíadas 2024:");
        foreach (var pais in paises)
        {
            Console.WriteLine(pais);
        }
    }
}
