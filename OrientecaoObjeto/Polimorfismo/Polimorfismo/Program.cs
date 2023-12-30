using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Polimorfismo
            List<Animal> listAnimais = new List<Animal>();

            Cavalo cavalo = new Cavalo();
            Cobra cobra = new Cobra();
            Gaevota gaevota = new Gaevota();

            // adicionando itens a lista lista do tipo ANIMAL só aceitara itens vinculados a classe ANIMAL

            listAnimais.Add(cavalo);
            listAnimais.Add(cobra);
            listAnimais.Add(gaevota);

            foreach (Animal animais in listAnimais)
            {
                animais.SeMover();// nesta linha o polimorfismo será ativado
            }
        }
    }
}