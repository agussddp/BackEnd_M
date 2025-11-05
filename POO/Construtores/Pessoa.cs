using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Pessoa
    {
        public string Nome;

        public int Idade;

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }
        
        public Pessoa()
        {
            Console.WriteLine($"objeto criado");
            
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");

            
        }
    }
}