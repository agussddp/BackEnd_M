    int  n1, n2;

    Console.WriteLine("Insira o primeiro numero");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("insira o segundo numero");
    n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"O maior número é: {n1}");
}

else if (n1 < n2)
{
    Console.WriteLine($"O maior número é: {n2}");
}

else
{
     Console.WriteLine("Os dois numeros são iguais");
}