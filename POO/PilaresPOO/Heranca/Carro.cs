using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Heranca
{
    public class Carro : Veiculos
    {
        public int QtdPortar;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"QtdPortar: {QtdPortar}");

        }
    }
}