using System;
using System.Collections.Generic;

namespace Ex03GestaoEstoque

{
    public class Program
    {
        public static void Main(string[] args)
        {

            // *********************Clientes*********************
            // Ciente padrão
            ClientePadrao clientePadrao = new ClientePadrao();
            clientePadrao.Nome = "Nome Padrão";
            clientePadrao.Id = 1;
            clientePadrao.Endereco = "Rua manoel lopes 185";

            // Ciente especial
            ClienteEspecial clienteespecial = new ClienteEspecial();
            clienteespecial.Id = 2;
            clienteespecial.Nome = "Nome Especial";
            clienteespecial.Endereco = "José gabriotti 583";

            // *********************Produtos*********************
            // Produtos Enlatados
            Enlatados AlmondegaLata = new Enlatados();
            AlmondegaLata.Descricao = "Almondegas en lata";
            AlmondegaLata.Estoque = 25;
            AlmondegaLata.Valor = 2.50;

            // Produtos laticvinios
            Laticinio leite = new Laticinio();
            leite.Descricao = "Leite Longa vida Uht";
            leite.Estoque = 2;
            leite.Valor = 15.00;

            // Produtos bebidas
            Bebida cocaColaLitro = new Bebida();
            cocaColaLitro.Descricao = "Coca cola retornavel 1 litro";
            cocaColaLitro.Estoque = 400;
            cocaColaLitro.Valor = 6.50;
            
            // gestão
            Gestao gestao = new Gestao();
            // cadastrar clientes
            gestao.CadastrarCliente(clientePadrao);
            gestao.CadastrarCliente(clienteespecial);

            // cadastrar produtos
            gestao.CadastrarProduto(leite);
            gestao.CadastrarProduto(cocaColaLitro);
            gestao.CadastrarProduto(AlmondegaLata);
            // listar clientes e produtos
            //gestao.ListarCliente();
            gestao.ListarProdutos();


            //venda 

            // Exemplo de venda para um usuário padrão
            clientePadrao.RealizarVenda(new List<Produto> { cocaColaLitro, leite });

            // Exemplo de venda para um usuário administrador
            clienteespecial.RealizarVenda(new List<Produto> { AlmondegaLata, cocaColaLitro, leite });


            gestao.ListarVendas();
        }
    }
}