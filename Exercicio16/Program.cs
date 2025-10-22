// Uma empresa decide dar aumento aos funcionários de acordo com o seu cargo,
// faça um programa que receba o cargo e o salário de
// um funcionário e calcule e imprima o salário reajustado.

// Produção       - 6.5
// Administrativo - 7.5
// Diretoria      - 12

//salario = salario * 1.065

using System.Net.WebSockets;

double salario, salarioNovo;
string cargo;

Console.WriteLine("Insira o cargo: Produção, Administrativo ou Diretoria");
cargo = Console.ReadLine();

Console.WriteLine("Insira o salario");
salario = double.Parse(Console.ReadLine());


if (cargo == "Produção")
{
    salarioNovo = salario + (salario * 0.065);
    Console.WriteLine($"O novo salario: {salarioNovo}");
}

else if (cargo == "Administrativo")
{
    salarioNovo = salario + (salario * 0.075);
    Console.WriteLine($"O novo salario: {salarioNovo}");
}

else if (cargo == "Diretoria")
{
    salarioNovo = salario + (salario * 0.12);
    Console.WriteLine($"O novo salario: {salarioNovo}");
}

else
{
    Console.WriteLine("cargo invalido");
}

