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