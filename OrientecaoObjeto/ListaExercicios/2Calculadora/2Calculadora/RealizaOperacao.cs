using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Calculadora
{
    public class RealizaOperacao : Operacao
    {
        

        public override double Dividir(double n1, double n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("Erro! Divisão por zero não é permitida.");
                return 0;
            }
            return n1 / n2;
        }

       

        public override double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

 

        public override double Somar(double n1, double n2)
        {
            return n1 + n2;
        }


        public override double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}
