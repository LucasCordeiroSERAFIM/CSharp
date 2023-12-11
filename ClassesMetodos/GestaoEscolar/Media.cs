namespace Program{
public class Media{ 
    public Media(){
        Console.WriteLine("Classe Media");
    }

    public double calcMedia(Aluno aluno){
        int qtdNotas = recebeMedia;
        double somaNotas = 0.0;
        double media = 0;
        
        foreach(double i in aluno.notas){
            somaNotas += i;
        }
        media = somaNotas/qtdNotas;
        return media;
    }

    public double[] recebeMedia(Aluno aluno){
        Console.WriteLine("Digite os números separados por espaço (exemplo: 1 2 3):");
        string input = Console.ReadLine();

        aluno.notas = ConverterParaDouble(input.Split(' '));
        return aluno.notas;
    }

    static double[] ConverterParaDouble(string[] valores)
    {
        double[] resultado = new double[valores.Length];
        for (int i = 0; i < valores.Length; i++)
        {
            if (double.TryParse(valores[i], out double valorConvertido))
            {
                resultado[i] = valorConvertido;
            }
            else
            {
                Console.WriteLine($"'{valores[i]}' não é um número válido e será ignorado.");
            }
        }
        return resultado;
}
}
}