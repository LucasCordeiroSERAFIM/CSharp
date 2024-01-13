using Ex03GestaoEstoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03GestaoEstoque
{
    public abstract class Cliente : ICliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Endereco { get; set; }

        // implementacao metodo da interface
        public abstract string Tipo { get; }
    }
}
