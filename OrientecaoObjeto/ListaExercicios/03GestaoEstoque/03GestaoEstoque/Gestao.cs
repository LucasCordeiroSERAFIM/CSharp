using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03GestaoEstoque
{
    public  class Gestao
    {
        private List<Cliente> clientes;
        private List<Produto> produtos;
        private List<Venda> vendas;


        public Gestao()
        {
            clientes = new List<Cliente>();
            produtos = new List<Produto>();
            vendas = new List<Venda>();
        }

        public void CadastrarUCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }

        public void ListarCliente()
        {
            Console.WriteLine("Lista de Usuários:");
            foreach (var c in clientes)
            {
                Console.WriteLine($"Nome: {c.Nome} - Tipo: {c.Tipo}");
            }
        }

        public void CadastrarProduto(Produto produto)
        {
            produtos.Add(produto);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        public void ListarProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.Descricao} - Preço: {produto.Preco:C} - Estoque: {produto.Estoque}");
            }
        }
        public void RealizarVenda(Venda venda)
        {
            vendas.Add(venda);
            Console.WriteLine("Venda realizada com sucesso!");
        }

        public void ListarVendas()
        {
            Console.WriteLine("Lista de Vendas:");
            foreach (var venda in vendas)
            {
                Console.WriteLine($"Cliente: {venda.Cliente} - Total: {venda.Total:C}");
            }
        }
    }
}
