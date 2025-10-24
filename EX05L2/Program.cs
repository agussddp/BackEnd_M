// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, 
// e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia 
// o número de maçãs compradas, calcule e escreva o valor total da compra.

int qtdMaca;
double Total;

Console.WriteLine($"Insira a quantidade de maças pegas");
qtdMaca = int.Parse(Console.ReadLine());

if (qtdMaca < 12)
{
    Total =  qtdMaca * 0.30 ;
    Console.WriteLine($"Total da compra {Total}");
}

else
{
    Total = qtdMaca * 0.25;
    Console.WriteLine($"Total da compra {Total}");
}