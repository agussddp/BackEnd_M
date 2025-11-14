using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX05
{
    public class ContaPoupança : Conta
    {
        public void CalcularRendimento()
        {
            double Rendimento = Saldo * 1.002;

            Console.WriteLine($"O rendimento do seu saldo é R${Rendimento}");
            
        }
    }
}