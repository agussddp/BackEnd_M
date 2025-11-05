using System.Diagnostics;
using Calculadora;

Console.Clear();

Calculator calc = new Calculator();
int opcao;
calc.n1 = 50;
calc.n2 = 10;

do
{


    Console.WriteLine($"                -------============------- ");
    Console.WriteLine($"Bem vindo ao ------==== CALULATOR ====------");
    Console.WriteLine($"                -------============------- ");
    Console.WriteLine();

    Console.WriteLine($"          ----======----          ");
    Console.WriteLine($"----===Escolha uma Operação===----");
    Console.WriteLine($"          ----======----          ");
    Console.WriteLine();

    Console.WriteLine($"1) --= Somar =--");
    Console.WriteLine($"2) --= Subtrair =--");
    Console.WriteLine($"3) --= Dividir =--");
    Console.WriteLine($"4) --= Multiplicar =--");
    Console.WriteLine($"0) --= Sair =--");
    Console.WriteLine("Opção: ");//exibe o texto sem pular linha
    opcao = int.Parse(Console.ReadLine());

if(opcao > 0 && opcao <= 4)
    {
        Console.WriteLine($"Escolha o primeiro número");
        calc.n1 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Escolha o segundo número");
        calc.n2 = int.Parse(Console.ReadLine());
        }



    //Você deve solicitar os dois números para o usuário e faze a conta conforme escolha do menu que o usuário fizer.


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine();
            break;

        case 1:
            Console.WriteLine($"Calculando a soma de {calc.n1} + {calc.n2}");
            Console.WriteLine($"Resultado: {calc.Somar()}");
            Console.WriteLine();
            break;

        case 2:
            Console.WriteLine($"Calculando a Subtração de {calc.n1} - {calc.n2}");
            Console.WriteLine($"Resultado: {calc.Subtrair()}");
            Console.WriteLine();
            break;

        case 3:
            Console.WriteLine($"Calculando a Divisão de {calc.n1} / {calc.n2}");
            Console.WriteLine($"Resultado: {calc.Dividir()}");
            Console.WriteLine();
            break;

        case 4:
            Console.WriteLine($"Calculando a Multiplicação de {calc.n1} / {calc.n2}");
            Console.WriteLine($"Resultado: {calc.Multiplicar()}");
            Console.WriteLine();
            break;

    }

    Console.WriteLine($"Digite <ENTER> para sair");
    Console.WriteLine();
    
    


} while (opcao != 0);

















