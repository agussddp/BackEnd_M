string[] nomes = new string[10];
float[] saldo = new float[10];
int totalClientes;
int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"---------------------------------");
    Console.WriteLine("==== Sistema Bancario Simples ====");
    Console.WriteLine($"---------------------------------");

    Console.WriteLine($"Escolha um opcao");
    Console.WriteLine($"1) Cadastrar cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Lista de clientes");
    Console.WriteLine($"0) Sair");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine($"Pressione ENTER para continuar...");
    Console.ReadLine();

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine();
            break;

        case 1:
            Cadastro();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListaClientes();
            break;

        default:
            Console.WriteLine($"Opção invalida");

            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar");
    Console.ReadLine();


} while (opcao != 0);


    void Cadastro()
{
    Console.WriteLine($"Funcao cadastrar cliente em desenvolvimento");

    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido!");
        return;
    }
    
    Console.WriteLine($"Digite o nome do cliente");
    nomes[totalClientes] = Console.ReadLine();

    Console.WriteLine($"Digite a idade de {nomes[totalClientes]}");
    saldo[totalClientes] = 0.50f;
    totalClientes++;

    Console.WriteLine($"Aluno Cadastrado com sucesso!");
}

    void Depositar()
{
    Console.WriteLine($"Funcao depositar");
}

    void Sacar()
{
    Console.WriteLine($"Funcao sacar");
}

    void Transferir()
{
    Console.WriteLine($"Funcao transferir");
}

    void ListaClientes()
{
    Console.WriteLine($"==lista de cliente==");

    0 - Eduardo Costa | saldo R$ 0,00
    1 - Maria Almeida | saldo R$ 0,00
}
