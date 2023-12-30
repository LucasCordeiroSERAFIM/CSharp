using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Alunos
{
    public abstract class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double n3 { get; set; }
        public double n4 { get; set; }
        public  abstract double CalcMedia();
    }
}
