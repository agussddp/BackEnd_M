//Pedir para o usuario digitar o nome, sobrenome, idade, saldo bancário e quanto investiu esse ano

//Camel Case - Letra maiuscula a partir da segunda palavra
using System.Security.AccessControl;

string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;

//Pascal Case - Primeira letra de cada palavra sempre maiúscula
Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse(Console.ReadLine());//converte o texto em int antes de jogar na variável

Console.WriteLine("Qual é o saldo da sua conta?");
saldoBancario = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é o seu investimento desse ano?");
investimentos = float.Parse(Console.ReadLine());


Console.Clear();

Console.WriteLine($"Nome: {nome} {sobrenomeDoFulano}");
Console.WriteLine($"Idade de {nome} é {idade}");
Console.WriteLine($"Saldo Bancário: {saldoBancario}");
Console.WriteLine($"Investimentos atuais R$: {investimentos}");