////Perguntar ao usuario quantos numeros ele quer digitar
//exibir, separadamente, os números pares e os numeros impares que ele digitar




using System.Data.Common;

Console.WriteLine("quantos numeros voce quer?");
int qtdNumeros = int.Parse(Console.ReadLine());
string pares = "pares: ";
string impares = "impares: ";


for (int i = 1; i < qtdNumeros; i++)
{
    Console.WriteLine($"digite o {i}ª numero ");
    int nuemroDigitado = int.Parse(Console.ReadLine());

    if (nuemroDigitado % 2 == 0)
    { //é par
        pares += nuemroDigitado.ToString() + ", ";
    }

    else
    {
        impares += nuemroDigitado.ToString() + ", ";
    }


}
Console.Clear();
Console.WriteLine("RESULTADO;");
Console.WriteLine();
Console.WriteLine(pares);
Console.WriteLine(impares);
