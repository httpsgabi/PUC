using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoHash
{
    internal class Hash
    {
        Lista[] tabela;
        Hash(int tam)
        {
            tabela = new Lista[tam];

            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = new Lista();
            }
        }

        public int FuncaoHash(int x)
        {
            return x % tabela.Length;
        }

        public bool Pesquisar(int x)
        {
            return tabela[FuncaoHash(x)].Pesquisar(x);
        }

        public void Inserir(int x)
        {
            if (Pesquisar(x) == true)
            {
                throw new Exception("Erro ao inserir!");
            }
            else
            {
                tabela[FuncaoHash(x)].InserirFim(x);
            }
        }

        public void Remover(int x)
        {
            if(Pesquisar(x) != true)
            {
                throw new Exception("Erro ao remover!");
            }
            else
            {
                tabela[FuncaoHash(x)].Remover(x);
            }
        }
    }
}
