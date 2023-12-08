namespace Program{

public class MinhaClasse1
{
    private void MetodoPrivado()
    {
        Console.WriteLine("Este é um método privado da MinhaClasse1.");
    }

    public void MetodoPublico()
    {
        Console.WriteLine("Este é um método público da MinhaClasse1.");
        MetodoPrivado(); // Chamando o método privado dentro da classe.
    }
}

}