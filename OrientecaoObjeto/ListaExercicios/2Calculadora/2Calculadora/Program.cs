using System;
namespace Ex2Calculadora
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RealizaOperacao realizaOperacao = new RealizaOperacao();

            Console.WriteLine("Digite o primeiro número:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a operação: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int escolha = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (escolha)
            {
                case 1:
                    resultado = realizaOperacao.Somar(n1, n2);
                    break;
                case 2:
                    resultado = realizaOperacao.Subtrair(n1, n2);
                    break;
                case 3:
                    resultado = realizaOperacao.Multiplicar(n1, n2);
                    break;
                case 4:
                    resultado = realizaOperacao.Dividir(n1, n2);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("O resultado é: " + resultado);

            Console.ReadLine();
        }
    }
}