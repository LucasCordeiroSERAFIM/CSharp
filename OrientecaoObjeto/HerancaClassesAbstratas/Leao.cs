namespace ProjetoPOO{
    public class Leao : Animal{

        public  override void Mover(){
            Console.WriteLine("Leao se movendo");
        }

        public string abtate {get; set;}

        public void Rugir(){
            Console.WriteLine("uraaaaaa");
        }

    }
}