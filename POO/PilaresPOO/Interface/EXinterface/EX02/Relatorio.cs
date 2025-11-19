using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX02
{
    public class Relatorio : IImprimivel
    {
        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo Relatorio...");
        }
    }
}