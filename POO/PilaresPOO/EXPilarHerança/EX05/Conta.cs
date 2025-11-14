using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX05
{
        public class Conta
    {
        public int Numero;

        public double Saldo;

        public void Depositar()
        {
            Console.WriteLine($"Valor para deposito: ");
            float valor = float.Parse(Console.ReadLine());
            Saldo = Saldo + valor;
            Console.WriteLine($"Seu saldo atualizado é R${Saldo}");
            
        }

        public void Sacar()
        {
            Console.WriteLine($"Valor para saque: ");
            float valor = float.Parse(Console.ReadLine());
            Saldo = Saldo - valor;
            Console.WriteLine($"Seu saldo atualizado é R${Saldo}");
        }
    }
}
