// Personalização de Garrafas - Classe Garrafa
// Crie uma classe que represente uma garrafa com pelo menos 3 propriedades e 2 métodos.
// Peça ao usuário para informar os dados para personalizar a garrafa e preencha 
// as propriedades do objeto
// Peça também o nome do usuário e ao final exiba o nome do usuário e as informações 
// da garrafa personalizada e a execução dos dois métodos
using ClassesEObjetos;

Console.Clear();

Garrafa garrafaPet = new Garrafa();
Console.WriteLine($"Olá! Digite o seu nome :D");
String nome = Console.ReadLine();

Console.WriteLine($"Digite a cor da sua garrafa:");
garrafaPet.Cor = Console.ReadLine();

Console.WriteLine($"Digite a capacidade da sua garrafa:");
garrafaPet.Capacidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o tamanho da sua garrafa:");
garrafaPet.Tamanho = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o formato da sua garrafa:");
garrafaPet.Formato = Console.ReadLine();

Console.Clear();

Console.WriteLine($"{nome} sua garrafa é {garrafaPet.Cor}, tem {garrafaPet.Capacidade}mls, tem {garrafaPet.Tamanho}cm e tem o formato de {garrafaPet.Formato}!");

garrafaPet.Abrir();

garrafaPet.Beber();