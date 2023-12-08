namespace Program{
public class Media{ 
    public Media(){
        Console.WriteLine("Classe Media");
    }

    public double calcMedia(Aluno aluno){
        int qtdNotas = aluno.notas.Length;
        double somaNotas = 0.0;
        
        foreach(double i in aluno.notas){
            somaNotas = i+i;
        }
        return 0;
    }
}
}