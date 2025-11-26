using System;
using Encapsulamento;

ContaBancaria ContaGiu = new ContaBancaria();

ContaGiu.Depositar(-100); 
ContaGiu.Depositar(20);   

Console.WriteLine($"Saldo atual: {ContaGiu.GetSaldo()}");
