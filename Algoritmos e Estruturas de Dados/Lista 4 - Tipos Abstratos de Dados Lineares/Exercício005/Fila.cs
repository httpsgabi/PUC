using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício005
{
    internal class Fila
    {
        private Arquivo[] filaArquivos;
        private int primeiro, ultimo;

        public Fila(int tamanho)
        {
            filaArquivos = new Arquivo[tamanho + 1];
            primeiro = ultimo = 0;
        }

        public int ObterTamanho()
        {
            return ultimo - primeiro;
        }


        public void Inserir(Arquivo arquivo)
        {

            if ((ultimo + 1) % filaArquivos.Length == primeiro)
            {
                throw new Exception("Erro, lista cheia");
            }

            filaArquivos[ultimo] = arquivo;
            ultimo = (ultimo + 1) % filaArquivos.Length;

        }

        public void Remover()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro, lista vazia");
            }

            primeiro = (primeiro + 1) % filaArquivos.Length;
        }

        public void Mostrar()
        {
            int i = primeiro;

            while (i != ultimo)
            {
                Console.WriteLine($"nome: {filaArquivos[i].Nome}, numero paginas: {filaArquivos[i].NumPaginas}");

                i = (i + 1) % filaArquivos.Length;
            }

        }

    }
}
