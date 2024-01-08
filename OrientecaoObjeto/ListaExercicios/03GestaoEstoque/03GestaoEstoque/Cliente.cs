using Ex03GestaoEstoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03GestaoEstoque
{
    public abstract class Cliente : ICliente
    {
        public string Nome { get; set; }
        public abstract string Tipo { get; }
    }
}
