namespace ProjetoPOO
{
    public class Program{
    public static void Main(string[] args){

    Leao leao = new Leao();
    leao.nome = "Leoneto";
    leao.peso = 150.50;
    leao.cor = "Rosa";
    leao.abtate = "Savana";

    leao.Mover();

    leao.Rugir();
    leao.Comer();
    
    Morcego morcego = new Morcego();
    morcego.nome = "Bat Mirim";
    morcego.cor = "Pretinho";
    morcego.peso = 0.500;
    morcego.Mover();
    morcego.Voar();

    }
    }
    
    
}