using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Alunos
{
    public  class AlunoBolsa :Aluno
    {
        public override double CalcMedia()
        {
            double media = (n1 + n2 + n3 + n4) / 4;
            return media;
        }
    }
}
