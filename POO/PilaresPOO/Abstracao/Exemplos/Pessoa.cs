using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
   public class Pessoa : Animal
    {
            public string Nome;

            public int Idade;

        public override void FazerSom()
        {
            Console.WriteLine($"Oii!");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"tac tac tac");
            
        }

        public void Dormir()
        {
            Console.WriteLine($"Zzzzzzz");
            
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"O nome da pessoa é {Nome} e a idade é {Idade}");
            
        }
    }
}