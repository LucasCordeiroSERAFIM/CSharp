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
        public string Cliente { get; set; }
        public List<Produto> Itens { get; set; }
        public double Total { get; set; }

        public double Caixa(string cliente, List<Produto> itens)
        {
            Cliente = cliente;
            Itens = itens;
            Total = 0;

             foreach (var item in Itens)
            {
                Total += item.Valor;
            }
            return Total;
        }
    }
}
