


int contador = 1;

Console.WriteLine($"quantas vezes rodar o while?");
int qtdVezes = int.Parse(Console.ReadLine());

while (contador <= 3)
{
    Console.WriteLine($"Contador é {contador}");
    contador++;
}