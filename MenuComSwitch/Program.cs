// MENU COM SWITCH CASE

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
            Console.WriteLine($"Boa escolha estamos preparando seu Hot Holl com carinho");
            Console.WriteLine();
            break;

        case 2:
            Console.WriteLine($"Boa escolha estamos preparando seu Temaki com carinho");
            Console.WriteLine();
            break;

        case 3:
            Console.WriteLine($"Boa escolha estamos preparando seu Sashimi com carinho");
            Console.WriteLine();
            break;

        case 4:
            Console.WriteLine($"Boa escolha estamos preparando seu Yakisoba com carinho");
            Console.WriteLine();
            break;

        case 5:
            Console.WriteLine($"Boa escolha estamos preparando seu Guioza com carinho");
            Console.WriteLine();
            break;

        case 6:
            Console.WriteLine($"Boa escolha estamos preparando seu Shimeji com carinho");
            Console.WriteLine();
            break;

    }

     Console.WriteLine($"Digite <Enter> para continuar");
     Console.ReadLine();
     

    //rodar o menu em loop
    //o menu deve aparecer // rodar pelo menos uma vez

} while (opcao != 0)
;