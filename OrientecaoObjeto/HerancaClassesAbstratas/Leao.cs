using OrientecaoObjeto;
using System;
namespace ProjetoPOO{
    public class Leao : Animal,IMamifero
    {
        public override void SeMover()
        {
            Console.WriteLine("Leão se move");
        }

        public void Rugir()
        {
            Console.WriteLine("Leão rugio");
        }

        public void SeAlimenta()
        {
            Console.WriteLine("Leão COMEU");
        }

        public void Mamar()
        {
            Console.WriteLine("Leao Filhote Mamou Interface Mamifero");
        }

        public void ComerCarne()
        {
            Console.WriteLine("Leao Adulto  Come carne Interface Mamifero");
        }
    }
}