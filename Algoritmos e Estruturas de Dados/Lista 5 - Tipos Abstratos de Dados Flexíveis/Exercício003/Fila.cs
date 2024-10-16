using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício003
{
    internal class Fila
    {
        private Celula primeiro;
        private Celula ultimo;

        public Fila()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }

        public void Inserir(Arquivo arquivo)
        {

            
            ultimo.Prox = new Celula(arquivo);
            ultimo = ultimo.Prox;
        }
        public Arquivo Remover()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro! Fila, vazia");
            }

            Celula tmp = primeiro;
            primeiro = primeiro.Prox;

            Arquivo arqRemovido = primeiro.Elemento;

            tmp.Prox = null;
            tmp = null;

            return arqRemovido;
        }
        public void Mostrar()
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.WriteLine($"nome: {i.Elemento.Nome}, numero paginas: {i.Elemento.NumPaginas}");
            }
        }
    }
}
