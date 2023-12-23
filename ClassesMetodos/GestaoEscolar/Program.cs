namespace Program{

    public class Program{
    public static void Main(string[] args){

    Aluno aluno = new Aluno();

    Console.WriteLine("Nome do Aluno");
    aluno.nome = Console.ReadLine();

    Console.WriteLine("idade do Aluno");
    aluno.idade = int.Parse(Console.ReadLine());


     Console.WriteLine("Primeira nota ");
     aluno.nota1 = double.Parse(Console.ReadLine());

     Console.WriteLine("Segunda nota ");
     aluno.nota2 = double.Parse(Console.ReadLine());

     Console.WriteLine("Terceira nota ");
       aluno.nota3 = double.Parse(Console.ReadLine());
            
     Console.WriteLine("Quarta nota ");
     aluno.nota4 = double.Parse(Console.ReadLine());

            Media media = new Media();
            Console.WriteLine("Media"+media.CalcMedia(aluno));
        }
    
}
}