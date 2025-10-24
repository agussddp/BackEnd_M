// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol 
// (os gols de cada time) e informa se o resultado foi um empate, se a vitória 
// foi do primeiro time ou do segundo time.

int golsA, golsB;

Console.WriteLine("Quantidade de gols time A");
golsA = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de gols time B");
golsB = int.Parse(Console.ReadLine());


if (golsA > golsB)
{
    Console.WriteLine($"Time A ganhou com {golsA} gols");
}

else if (golsB > golsA)
{
    Console.WriteLine($"Time B ganhou com {golsB} gols");
}

else
{
    Console.WriteLine($"Os dois times empataram");
}