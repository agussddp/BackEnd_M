int qtdvezes = 1;
int contador = 1;

Console.WriteLine($"Quantos números você quer digitar?");
qtdvezes = int.Parse(Console.ReadLine());

while (contador <= qtdvezes)
{
    Console.WriteLine($"Digite o numero");
    int numeroDigitado = int.Parse(Console.ReadLine());
    if (numeroDigitado % 2 == 0)
    {
        Console.WriteLine($"Número par digitado: {numeroDigitado}");
    }
    contador++;
}