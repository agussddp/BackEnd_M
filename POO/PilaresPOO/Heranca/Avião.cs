using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Avião : Veiculos
    {
        public int QtdAssentos;

        public void Voar()
        {
            Console.WriteLine($"Levantando vôo...");
            
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"QtdPortar: {QtdAssentos}");

        }
        

    }
}