using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX04T
{
    public class Professor : Pessoa
    {
        public string Disciplina;

            public void ExibirDados()
        {
            Console.WriteLine($"O nome do Aluno é {Nome}, a idade é {Idade} anos e a disciplina é {Disciplina}!");
        }
    }
}