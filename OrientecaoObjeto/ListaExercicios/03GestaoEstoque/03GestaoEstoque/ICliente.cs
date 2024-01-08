using _03GestaoEstoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03GestaoEstoque
{
    public  interface  ICliente
    {
        public string Nome { get; set; }
        public abstract string Tipo { get; }
    }
}
