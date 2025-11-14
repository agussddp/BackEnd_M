using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
   public class ContaPoupanca : ContaBancaria
    {
        public double Saldo = 0;

        private double TaxaSaque = 3;


        public ContaPoupanca(double SaldoInicial)
        {
            Saldo = SaldoInicial;
        }




        public override void Depositar(double Valor)
        {
            if (Valor <= 0)
            {
                Console.WriteLine($"O valor do depósito deve ser positivo");
                return;//para a execução do método aqui

            }

            Saldo += Valor;

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