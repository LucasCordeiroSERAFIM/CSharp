using System;
namespace ProjetoPOO{
    public abstract class Animal{
        // classe abstrata nao instancia 
        // utilizada como classe base para heransa
        // pode criar metodo abstrato que sera subescrevido pelas classes filhas
        // em questão de herança sempre utilizar classes abstratas

        public string nome {get;set;}
        public double peso {get;set;}
        public double autura {get;set;}

         public string cor {get;set;}


        public abstract void SeMover();
      
     public void SeAlimenta()
        {
            Console.WriteLine("Animal se alimentando");
        }
    }
    
}