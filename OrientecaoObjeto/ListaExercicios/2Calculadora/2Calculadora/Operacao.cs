using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Calculadora
{
    public abstract   class Operacao

    {
        public abstract  double Somar(double n1, double n2);
        public abstract double Subtrair(double n1, double n2);
        public abstract double Multiplicar(double n1, double n2);
        public abstract double Dividir(double n1, double n2);
    }
}
