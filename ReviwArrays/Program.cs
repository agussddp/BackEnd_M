string[] nomes = new string[4]; //de 0 a 3

nomes[0] = "Maria";
nomes[1] = "Giulia";
nomes[2] = "Grazi";

Console.WriteLine($"1° nome: {nomes[0]}");
Console.WriteLine($"2° nome: {nomes[1]}");
Console.WriteLine($"3° nome: {nomes[2]}");
Console.WriteLine($"4° nome: {nomes[3]}");

Console.WriteLine($"Tamanho do Array: {nomes.Length}");


    for (var i = 0; i < nomes.Length; i++)
    {
     Console.WriteLine($"{i}° Nome: {nomes[0]}");
    }