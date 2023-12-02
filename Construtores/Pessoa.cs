namespace Program
{

    public class Pessoa
    {
 
        
        private string Nome = "";
         private int Idade;
        // Cosntrutor 
        /*
        Pré inicialisa itens da classe
        */
    public Pessoa(string nome, int idade )
        {
            Nome = nome;
            Idade = idade;
        }


        public void DadosPessoa()
        {
            Console.Write($"O nome da pessoal é:{Nome} ");
            Console.WriteLine($"a idade  da pessoal é:{Idade} ");
        }
    }
}