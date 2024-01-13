using Ex03GestaoEstoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03GestaoEstoque
{
    public abstract class Cliente : ICliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public List<Venda> Vendas { get; set; } = new List<Venda>();

        // implementacao metodo da interface
        public abstract string Tipo { get; }

        // implementando o médoto de venda 

        public void RealizarVenda(List<Produto> itens)
        {
            Venda venda = new Venda(this.Nome, itens);
            Vendas.Add(venda);
            Console.WriteLine($"Venda realizada para o usuário {this.Nome}!");
        }
    }
}
