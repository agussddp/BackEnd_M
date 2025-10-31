using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Crie uma classe ContaBancaria com os atributos titular e saldo.
// Crie os métodos Depositar(valor) e Sacar(valor).
// Mostre o saldo atual após cada operação no console.

namespace ClassesEObjetos
{
    public class ContaBancaria
    {

        public string Titular;

        public float Saldo;

        public void Depositar(float _valorDeposito)
        {
            if (_valorDeposito <= 0)
            {
                Console.WriteLine($"O valor do depósito deve ser maior do que R$ 0");
                return;

            }

            Saldo += _valorDeposito;

            Console.WriteLine($"Depósito realizado! Novo Saldo: {Saldo}");

        }

        public void Sacar(float _valorSaque)
        {
            if (_valorSaque <= 0 && _valorSaque < Saldo)
            {
                Console.WriteLine($"Saldo Atual: {Saldo}");
                Console.WriteLine($"Não é possível sacar este valor solicitado, por favor insira um valor válido :()");

            }

            Saldo -= _valorSaque;

            Console.WriteLine($"Saque realizado! Novo Saldo: {Saldo}");

        }

    }
}