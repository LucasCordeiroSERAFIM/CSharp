namespace ProjetoPOO{
    public class Morcego : Animal{

        public  override void Mover(){
            Console.WriteLine("Morcego se movendo");
        }

        
        public string Voar(){
            return "Morcego voou";
        } 

        public override Comer(){
            console.WriteLine("morcego chupando sangue");
        }
    }
}