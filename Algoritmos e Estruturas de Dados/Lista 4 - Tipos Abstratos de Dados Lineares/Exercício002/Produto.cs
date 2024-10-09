using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Produto
    {
        private string nome;
        private int quant;
        private double preco;

        public Produto(string nome, int quant, double preco)
        {
            this.nome = nome;
            this.quant = quant;
            this.preco = preco;
        }

        public string Nome { get; set; }
        public string Quant { get; set; }
        public string Preco { get; set; }

        public override string ToString()
        {
            return $"Nome: {quant}, Quantidade: {quant}, Preço: {preco}";
        }
    }
}
