using OrientecaoObjeto;
using System;
namespace ProjetoPOO{
    public class Louro : Animal,IAve{
        public override void SeMover()
        {
            Console.WriteLine("Louro Anda no chão");
        }

        public void Falar()
        {
            Console.WriteLine("Louro Fala Curupaco");
        }
        public void SeAlimenta()
        {
            Console.WriteLine("Louro comeu");
        }

        public void Voar()
        {
            Console.WriteLine("Louro Voa Interface Ave");
        }

        public void ComerFruta()
        {
            Console.WriteLine("Louro Coem Fruta Interface Ave");
        }
    }
}