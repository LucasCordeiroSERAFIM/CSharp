namespace ProjetoInicio {

class Program{
    static void Main(string[] args){
      /*  int idade = 32;
        float altura = 1.65;
        char genero = 'M';
        int[] idades = {10,9,88,2,4,1001};
        int[] idades = new int[5] {5,44,2,3,8};
        Console.WriteLine("olá mundo");
        */

        /*COLEÇÃO*/
        //lista
        List<int>idades = new List<int>();

        idades.Add(10);
        idades.Add(1);
        idades.Add(33);
        int qtd = idades.Count;
        Console.WriteLine($"quantidade lista {qtd}");
    }
 }
}