using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ContaCorrente : ContaBancaria

    {
        public double Saldo = 0;
        private double TaxaSaque = 5;

        public ContaCorrente(double saldoInicial)
        {
            Saldo = saldoInicial;
        }



        public override void Depositar(double valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine($"O valor do deposito deve ser positivo");
                return;//para a execução do metodo aq
            }

            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            double TotalComTaxa = (valor / 100 * TaxaSaque) + valor;
            if(valor <= 0 && Saldo >= TotalComTaxa)
            {
                Console.WriteLine($"O valor do saque deve ser positivo//Necessario ter dinheiro na conta");
                return;
            }

            Saldo -= TotalComTaxa;
        }
    }
}