namespace ProjetoPOO{
    public class Morcego : Animal{

        public  override void Mover(){
            Console.WriteLine("Morcego se movendo");
        }

        
        public string Voar(){
            return "Morcego voou";
        } 
    }
}