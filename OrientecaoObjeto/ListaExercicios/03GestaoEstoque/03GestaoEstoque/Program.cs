using System;
namespace Ex03GestaoEstoque

{
    public class Program
    {
        public static void Main(string[] args)
        {
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
            
            
            // gestão
            Gestao gestao = new Gestao();

            gestao.CadastrarCliente(clientePadrao);

            gestao.CadastrarCliente(clienteespecial);

            // listar clientes 
            gestao.ListarCliente();
        }
    }
}