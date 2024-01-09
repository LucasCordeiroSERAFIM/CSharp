using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03GestaoEstoque
{
    public class Produto : IProduto
    {
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        // interface 
        public override string Setor {get; set;}
    }

}
