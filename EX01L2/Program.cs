//Faça um programa que o usuário informe o salário recebido e o total gasto. 
//Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não 
// ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

float salario, gastos;

Console.WriteLine("Informe seu salario");
salario = float.Parse(Console.ReadLine()); 

Console.WriteLine("Informe o valor total de gastos");
gastos = float.Parse(Console.ReadLine());

if (salario > gastos)
{
    Console.WriteLine("Gastos dentro do orçamento");
}
else
{
    Console.WriteLine("Orçamento estourado");
}



