
namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
           Calculadora calculadora = new Calculadora();

           Console.WriteLine("Digite um Numero");
           double num1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Digite outro Numero");
           double num2 = Convert.ToDouble(Console.ReadLine());

           double resultado = calculadora.Somar(num1,num2);
            Console.WriteLine($"O resultado da soma é {resultado}");
        }

      
    }
}