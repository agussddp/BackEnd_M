// Exercício 2 – Funcionários de uma empresa
// Crie uma classe Funcionario com as propriedades Nome e SalarioBase.
// Crie uma classe Gerente que herde de Funcionario e possua um bônus adicional.
// Implemente um método CalcularSalario() que retorne o salário total considerando o bônus do gerente.
// Crie objetos das duas classes e exiba os salários no console.

using EXheranca;

Funcionario Giu = new Funcionario();
Giu.Nome = "Giulia";
Giu.CalcularSalario();

Gerente Mari = new Gerente();
Mari.Nome = "Maria";
Mari.BonusAdicional = 600f;
Mari.CalcularSalario();