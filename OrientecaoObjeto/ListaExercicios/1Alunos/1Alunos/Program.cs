using System;
namespace Ex1Alunos
{
    public class Program
    {
        public static void Main(string[] args) {

            /**Aluno comum 1**/
            AlunoComun alunoComun1 = new AlunoComun();

            Console.WriteLine("Nome do Aluno 1");
            alunoComun1.Nome = Console.ReadLine();

            Console.WriteLine("idade do Aluno 1");
            alunoComun1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Primeira nota Aluno 1");
            alunoComun1.n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segunda nota Aluno 1");
            alunoComun1.n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Terceira nota Aluno 1");
            alunoComun1.n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Quarta nota Aluno 1");
            alunoComun1.n4 = double.Parse(Console.ReadLine());

            double mediaFinalA1 = alunoComun1.CalcMedia();
            /***Aluno comun 2***/

            AlunoComun alunoComun2 = new AlunoComun();

            Console.WriteLine("Nome do Aluno 2");
            alunoComun2.Nome = Console.ReadLine();

            Console.WriteLine("idade do Aluno 2");
            alunoComun2.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Primeira nota do Aluno 2");
            alunoComun2.n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segunda nota do Aluno 2");
            alunoComun2.n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Terceira nota do Aluno 2");
            alunoComun2.n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Quarta nota do Aluno 2");
            alunoComun2.n4 = double.Parse(Console.ReadLine());

            double mediaFinalA2 = alunoComun2.CalcMedia();

            /**Aluno bolsa 1 **/
           
            AlunoBolsa alunoBolsa1 = new AlunoBolsa();

            Console.WriteLine("Nome do Aluno 3");
            alunoBolsa1.Nome = Console.ReadLine();

            Console.WriteLine("idade do Aluno 3");
            alunoBolsa1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Primeira nota Aluno 3");
            alunoBolsa1.n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segunda nota Aluno 3");
            alunoBolsa1.n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Terceira nota Aluno 3");
            alunoBolsa1.n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Quarta nota Aluno 3");
            alunoBolsa1.n4 = double.Parse(Console.ReadLine());

            double mediaFinalA3 = alunoBolsa1.CalcMedia();


            /**Aluno bolsa 2 **/

            AlunoBolsa alunoBolsa2 = new AlunoBolsa();

            Console.WriteLine("Nome do Aluno ");
            alunoBolsa2.Nome = Console.ReadLine();

            Console.WriteLine("idade do Aluno 1");
            alunoBolsa2.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Primeira nota Aluno 1");
            alunoBolsa2.n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segunda nota Aluno 1");
            alunoBolsa2.n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Terceira nota Aluno 1");
            alunoBolsa2.n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Quarta nota Aluno 1");
            alunoBolsa1.n4 = double.Parse(Console.ReadLine());
            double mediaFinalA4 = alunoBolsa2.CalcMedia();

            if (mediaFinalA1 >= 7)
            {
                Console.WriteLine("Aluno" + alunoComun1.Nome+"Está Aprovado com média"+mediaFinalA1);

            }
            else if (mediaFinalA1 < 7) {
                Console.WriteLine("Aluno" + alunoComun1.Nome + "Está Reprovado com média" + mediaFinalA1);
            }
            if (mediaFinalA2 >= 7)
            {
                Console.WriteLine("Aluno" + alunoComun2.Nome + "Está Aprovado com média" + mediaFinalA2);

            }
            else if (mediaFinalA2 < 7)
            {
                Console.WriteLine("Aluno" + alunoComun2.Nome + "Está Reprovado com média" + mediaFinalA2);
            }

            if (mediaFinalA3 >= 6)
            {
                Console.WriteLine("Aluno" + alunoBolsa1.Nome + "Está Aprovado com média" + mediaFinalA3);

            }

            else if (mediaFinalA3 < 6)
            {
                Console.WriteLine("Aluno" + alunoBolsa1.Nome + "Está provado com média" + mediaFinalA3);

            }

            if (mediaFinalA4 >= 6)
            {
                Console.WriteLine("Aluno" + alunoBolsa2.Nome + "Está Aprovado com média" + mediaFinalA4);

            }

            else if (mediaFinalA4 < 6)
            {
                Console.WriteLine("Aluno" + alunoBolsa2.Nome + "Está Reprovado com média" + mediaFinalA4);

            }

        }
    }
    }