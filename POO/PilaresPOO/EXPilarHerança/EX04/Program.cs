// Exercício 4 – Escola
// Crie uma classe Pessoa com as propriedades Nome e Idade.
// Crie as classes Aluno e Professor que herdem de Pessoa.
// O Aluno deve ter uma propriedade Curso e o Professor uma propriedade Disciplina.
// Crie objetos de ambas as classes e exiba suas informações no console.


using EX04;


Console.Clear();

Aluno Mari = new Aluno();
Mari.Nome = "Maria";
Mari.Idade = 18;
Mari.Curso = "DEV";
Mari.ExibirDados();

Professor Giu = new Professor();
Giu.Nome = "Giulia";
Giu.Idade = 17;
Giu.Disciplina = "Games";
Giu.ExibirDados();