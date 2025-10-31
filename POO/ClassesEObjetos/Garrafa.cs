using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class Garrafa
    {
        public string Cor;

        public int Capacidade;

        public int Tamanho;

        public string Formato;

        public void Beber()
        {
            Console.WriteLine($"Glu, glu, glu...");
        }
        
        public void Abrir()
        {
            Console.WriteLine($"Thro...");
            
        }
    }
}