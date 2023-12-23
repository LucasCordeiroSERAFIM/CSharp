namespace Program{
public class Media{ 
    public Media(){
        Console.WriteLine("Classe Media");
    }
    public double CalcMedia(Aluno aluno)
        {
            double soma = aluno.nota1 + aluno.nota2 + aluno.nota3 + aluno.nota4;
            double mendia = soma / 4;
            return mendia;
        }

 
}
}