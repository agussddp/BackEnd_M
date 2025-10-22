//Faça um programa que pergunte para o usuário a quantidade de números que ele
//quer digitar. Após isso crie um laço que exiba o número que o usuário digitar apenas
//se for PAR. Utilize a estrutura WHILE.

int qtdLetras = 0;

Console.WriteLine("Digite quantas letras tem seu nome");
qtdLetras = int.Parse(Console.ReadLine());
string nome = "";


for (int i = 1; i <= qtdLetras; i++)
{
    Console.WriteLine($"Qual a {i}ª letra");
    nome += Console.ReadLine();
}

Console.WriteLine($"Seu nome é : {nome}");