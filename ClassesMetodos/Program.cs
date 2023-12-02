
namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
           Calculadora calculadora = new Calculadora(); //instanciando a classe

           Calculo calculo = new Calculo();

           Console.WriteLine("Digite um Numero");
           calculo.Numero1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Digite outro Numero");
           calculo.Numero2 = Convert.ToDouble(Console.ReadLine());

           double resultado = calculadora.Somar(calculo);
            Console.WriteLine($"O resultado da soma é {resultado}");
        }

      
    }
}