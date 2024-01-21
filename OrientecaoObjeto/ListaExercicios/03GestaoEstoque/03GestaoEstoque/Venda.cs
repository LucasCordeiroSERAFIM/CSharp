using Ex03GestaoEstoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03GestaoEstoque
{
    public class Venda
    {
        public string NCliente { get; set; }
        public List<Produto> Itens { get; set; }

    }
}
