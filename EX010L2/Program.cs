// baseado no programa do exercício número 9, crie um programa que contenha o menu 
// para os exercícios de 1 a 6, onde cada programa/menu deve executar uma função.




int opcao;

do
{
    Console.WriteLine("-------------------------------");
    Console.WriteLine("            Bem Vindo          ");
    Console.WriteLine("               ao              ");
    Console.WriteLine("        Menu de Exercicios     ");
    Console.WriteLine("-------------------------------");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Escolha uma opção no menu abaixo:");
    Console.WriteLine();

    Console.WriteLine("1)   Exercicio 01 ");
    Console.WriteLine("2)   Exercicio 02 ");
    Console.WriteLine("3)   Exercicio 03 ");
    Console.WriteLine("4)   Exercicio 04 ");
    Console.WriteLine("5)   Exercicio 05 ");
    Console.WriteLine("6)   Exercicio 06 ");
    Console.WriteLine("7)   Exercicio 07 ");
    Console.WriteLine("0)   Sair");
    Console.WriteLine("Opção: ");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine();
        break;

        case 1:
                Exercicio01();
        break;

        case 2:
                Exercicio02();
        break;

        case 3:
                Exercicio03();
        break;

        case 4:
                Exercicio04();
        break;

        case 5:
                Exercicio05();
        break;

        case 6:
                Exercicio06();
        break;
        
        case 7:
                Exercicio07();
        break;

    }


     Console.WriteLine($"Digite <Enter> para continuar");
     Console.ReadLine();
     

} while (opcao != 0);


void Exercicio01()
{
    Console.WriteLine("Programa salário recebido e o total gasto.");
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
}

void Exercicio02()

{
    Console.WriteLine($"placar de um jogo de futebol");
    
    int golsA, golsB;

    Console.WriteLine("Quantidade de gols time A");
    golsA = int.Parse(Console.ReadLine());

    Console.WriteLine("Quantidade de gols time B");
    golsB = int.Parse(Console.ReadLine());


    if (golsA > golsB)
    {
        Console.WriteLine($"Time A ganhou com {golsA} gols");
    }

    else if (golsB > golsA)
    {
        Console.WriteLine($"Time B ganhou com {golsB} gols");
    }

    else
    {
        Console.WriteLine($"Os dois times empataram");
    }
}

void Exercicio03()
{
    Console.WriteLine($"programa que leia as medidas dos lados de um triângulo");
    
    float lado1, lado2, lado3;

    Console.WriteLine("Medida lado 1");
    lado1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Medida lado 2");
    lado2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Medida lado 3");
    lado3 = float.Parse(Console.ReadLine());

    if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
    {
        Console.WriteLine("Triângulo    Equilátero");
    }

    else if (lado1 == lado2)
    {
        Console.WriteLine("Triângulo    Isóscele");
    }

    else
    {
        Console.WriteLine(" Triângulo    Escaleno");
    }
}

void Exercicio04()
{
    Console.WriteLine($"programa que verifica a validade de uma senha ");
    
    int senhaCorreta = 1234;
    int senhaInsirida;

    Console.WriteLine("Insira a senha");
    senhaInsirida = int.Parse(Console.ReadLine());

        if (senhaCorreta == senhaInsirida)
        {
        Console.WriteLine("ACESSO PERMITIDO");
        }

        else
        {
        Console.WriteLine("ACESSO NEGADO");
        }
}

void Exercicio05()
{
    Console.WriteLine($"programa que le o número de maçãs compradas e retorna o total");

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
}

void Exercicio06()
{
    Console.WriteLine($"Programa que verifica media e frequencia do aluno");

    double media, frequencia;

    Console.WriteLine($"Insira sua media");
    media = double.Parse(Console.ReadLine());

    Console.WriteLine($"Insira sua frequencia");
    frequencia = double.Parse(Console.ReadLine());


        if (media >= 7 && frequencia >= 75)
        {
            Console.WriteLine($"Aprovado");
        }

        else if (media > 3 && media < 7 && frequencia >= 75)
        {
            Console.WriteLine($"Direito a uma última avaliação de recuperação");
        }

        else
        {
            Console.WriteLine($"Reprovado");
        } 
}

void Exercicio07()
{
    Console.WriteLine($"Menu com Switch Case");

    int opcao;

    do
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("            Bem Vindo          ");
        Console.WriteLine("               ao              ");
        Console.WriteLine("          Paradis Sushi        ");
        Console.WriteLine("-------------------------------");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Escolha uma opção no menu abaixo:");
        Console.WriteLine();

        Console.WriteLine("1)   Hot Holl .......................... R$ 29,90");
        Console.WriteLine("2)   Temaki   .......................... R$ 30,00");
        Console.WriteLine("3)   Sashimi  .......................... R$ 67,10");
        Console.WriteLine("4)   Yakisoba .......................... R$ 35,90");
        Console.WriteLine("5)   Guioza   .......................... R$ 45,90");
        Console.WriteLine("6)   Shimeji  .......................... R$ 50,90");
        Console.WriteLine("0)   Sair");
        Console.WriteLine("Opção: ");//exibe o texto sem pular linha
        opcao = int.Parse(Console.ReadLine());


        switch (opcao)
        {
            case 0:
                Console.WriteLine($"Saindo...");
                Console.WriteLine();

                break;

            case 1:
                    HotHoll();
            break;

            case 2:
                    Temaki();
            break;

            case 3:
                    Sashimi();
            break;

            case 4:
                    Yakisoba();
            break;

            case 5:
                    Guioza();
            break;

            case 6:
                    Shimeji();
            break;

        }


        Console.WriteLine($"Digite <Enter> para continuar");
        Console.ReadLine();
        

    } while (opcao != 0)
    ;


    void HotHoll()
    {
        Console.WriteLine($"Boa escolha estamos preparando seu Hot Holl com carinho");
        Console.WriteLine();
        }

    void Temaki()
    {
        Console.WriteLine($"Boa escolha estamos preparando seu Temaki com carinho");
        Console.WriteLine();
        }

    void Sashimi()
    {
        Console.WriteLine($"Boa escolha estamos preparando seu Sashimi com carinho");
        Console.WriteLine();
        }

    void Yakisoba()
    {
        Console.WriteLine($"Boa escolha estamos preparando seu Yakisoba com carinho");
        Console.WriteLine();
        }

    void Guioza()
    {
        Console.WriteLine($"Boa escolha estamos preparando seu Guioza com carinho");
        Console.WriteLine();
        }

    void Shimeji()
    {
        Console.WriteLine($"Boa escolha estamos preparando seu Shimeji com carinho");
        Console.WriteLine();
        }
        
}