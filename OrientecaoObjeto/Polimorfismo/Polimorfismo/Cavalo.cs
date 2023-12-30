using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cavalo : Animal
    {
        public override void SeMover()
        {
            Console.WriteLine("Cavalo TROTA");
        }
    }
}
