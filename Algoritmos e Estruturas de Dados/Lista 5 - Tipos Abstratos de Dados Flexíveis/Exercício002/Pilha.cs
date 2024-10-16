using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Pilha
    {
        private Celula topo;

        public Pilha(){
            topo = null;
        }

        public void Inserir(int num)
        {
            Celula tmp = new Celula(num);

            tmp.Prox = topo;
            topo = tmp;

            tmp = null;
        }
        public int Remover()
        {
            if (topo == null)
            {
                throw new Exception("Erro, pilha vazia");
            }

            int numRemovido = topo.Elemento;
            Celula tmp = new Celula();

            tmp = topo;
            topo = topo.Prox;

            tmp.Prox = null;
            tmp = null;

            return numRemovido;
        }

        public void Mostrar()
        {
            for (Celula i = topo; i != null; i = i.Prox)
            {
                Console.Write(i.Elemento);
            }
        }
    }
    
}
