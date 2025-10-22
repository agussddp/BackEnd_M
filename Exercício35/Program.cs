// Faça um programa que solicite ao usuário um número de repetições “x”. Para cada
// repetição solicite dois números e imprima qual é o maior deles.

int qtdvezes = 0;
int contador = 1;
int n1, n2;
Console.WriteLine($"Quantos números você quer digitar?");
qtdvezes = int.Parse(Console.ReadLine());

while (contador <= qtdvezes)
{
    Console.WriteLine($"Digite o primeiro numero");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo numero");
    n2 = int.Parse(Console.ReadLine());


    if (n1 > n2)
    {
        Console.WriteLine($"O {n1} é maior que {n2}");
    }
    else if (n2 > n1)
    {
        Console.WriteLine($"O {n2} é maior que {n1}");
    }
    else
    {
        Console.WriteLine($"Os numeros sao iguais");
    }




        contador++;


}


