using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício001
{
    internal class Cliente
    {
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private string MetodoPagamento { get; set; }
        private long Telefone { get; set; }
        private float TotCompra { get; set; }

        public Cliente(string nome, string endereco, long telefone)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.MetodoPagamento = "Método de Pagamento não definido";
            this.TotCompra = 0;
        }
        public Cliente(string nome, string endereco, string metodoPagamento, long telefone, float totCompra)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.MetodoPagamento = metodoPagamento;
            this.TotCompra = totCompra;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"\nNome do cliente: {Nome}");
            Console.WriteLine($"Endereço do cliente: {Endereco}");
            Console.WriteLine($"Telefone do cliente: {Telefone}");
            Console.WriteLine($"Método de pagamento do cliente: {MetodoPagamento}");
            Console.WriteLine($"Total de compra do cliente: {TotCompra}");
            Console.WriteLine("---------------------------------------------\n");
        }

    }
}
