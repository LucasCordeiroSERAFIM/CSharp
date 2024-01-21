using Ex03GestaoEstoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03GestaoEstoque
{
    public class Gestao
    {
        // Listar itens
        private List<Cliente> clientes;
        private List<Produto> produtos;
        private List<Venda> vendas;


        public Gestao()
        {
            // estancia das listas 
            clientes = new List<Cliente>();
            produtos = new List<Produto>();
            vendas = new List<Venda>();
        }

        // cadastrar cliente 
        public void CadastrarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }

        // listar cliente
        public void ListarCliente()
        {
            Console.WriteLine("Lista de Usuários:");
            foreach (var c in clientes)
            {
                Console.WriteLine($"Nome: {c.Nome} - Tipo: {c.Tipo} - Endereco: {c.Endereco}");
            }
        }

        // cadastrar produto
        public void CadastrarProduto(Produto produto)
        {
            produtos.Add(produto);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        // listar produto
        public void ListarProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.Descricao} - Preço: {produto.Valor:C} - Estoque: {produto.Estoque}");
            }
        }

        // cadastrar Venda 
        public void CadastrarVenda(Venda venda)
        {
            vendas.Add(venda);
            Console.WriteLine("Venda cadastrada com sucesso!");
        }
        // listagem de vendas 
        public void ListarVendas()
        {
            Console.WriteLine("Lista de Vendas:");
            foreach (var vend in vendas)
            {
                Console.WriteLine($"Cliente : {vend.NCliente} - Comprou: {vend.Itens:C}");
            }
        }

      

    }
}

        
    


  


