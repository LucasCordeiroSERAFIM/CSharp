using Ex03GestaoEstoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03GestaoEstoque
{
    public  abstract class Produto : IProduto
    {
        public int Id { get; set; }

        public int Estoque { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        // metodo abstrato
        public abstract string Setor { get; }
    }
}
