float n1, n2, n3, n4, media;


    Console.WriteLine("Insira nota 1");
    n1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Insira nota 2");
    n2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Insira nota 3");
    n3 = float.Parse(Console.ReadLine());

    Console.WriteLine("Insira nota 4");
    n4 = float.Parse(Console.ReadLine());

    media = (n1 + n2 + n3 + n4) / 4;
    Console.WriteLine($"Media: {media}");

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}

else if (media >= 5)
{
    Console.WriteLine("Recuperação");
}

else
{
    Console.WriteLine("Reprovado");
}