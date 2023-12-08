namespace Program{
public class MinhaClasse2
{
    private void MetodoPrivado()
    {
        Console.WriteLine("Este é um método privado da MinhaClasse2.");
    }

    public void MetodoPublico()
    {
        Console.WriteLine("Este é um método público da MinhaClasse2.");
        MetodoPrivado(); // Chamando o método privado dentro da classe.
    }
}

}