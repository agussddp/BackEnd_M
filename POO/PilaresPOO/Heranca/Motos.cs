using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Motos : Veiculos
    {
        public int QtdCapacete;

        public void SomDaMoto()
        {
            Console.WriteLine($"grrrrrrrrwmmmmm");

        }
        
         public void Acelerar()
        {
            Console.WriteLine($"UUUUUUUUUUUUUUUUUUUUUUU tutututututu");

        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"QtdPortar: {QtdCapacete}");

        }
    }
}