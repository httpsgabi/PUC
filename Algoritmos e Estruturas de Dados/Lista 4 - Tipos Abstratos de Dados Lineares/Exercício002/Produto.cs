using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercício002
{
    internal class Produto
    {
        private string nome;
        private int quant;
        private double preco;

        Produto()
        {
            nome = "";
            quant = 0;
            preco = 0;
        }

        public string Nome { get; set; }
        public string Quant { get; set; }
        public string Preco { get; set; }

        public string ToString()
        {
            return $"Nome: {quant}, Quantidade: {quant}, Preço: {preco}";
        }
    }
}
