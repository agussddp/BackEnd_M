using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX04T
{
    public class Aluno : Pessoa
    {
        public string Curso;

        public void ExibirDados()
        {
            Console.WriteLine($"O nome do Aluno é {Nome}, a idade é {Idade} anos e o curso é {Curso}!");
        }
    }
}