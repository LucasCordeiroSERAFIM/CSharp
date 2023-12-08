namespace Program{
class Program
{
    static void Main(string[] args)
    {
        MinhaClasse1 classe1 = new MinhaClasse1();
        MinhaClasse2 classe2 = new MinhaClasse2();

        classe1.MetodoPublico(); // Chamando o método público da MinhaClasse1
        classe2.MetodoPublico(); // Chamando o método público da MinhaClasse2
    }
}
}