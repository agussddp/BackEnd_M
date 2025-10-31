using System.Runtime.InteropServices;

String [] nomes = new string [10];
float[] saldos = new float[10];
int totalClientes = 0;

int opcao;

do
{
Console.Clear();

Console.WriteLine($"-----------SISTEMA BANCARIO SIMPLES-----------");
Console.WriteLine($"");
Console.WriteLine($"");


Console.WriteLine($"----Escolha uma opção:");
Console.WriteLine($"");
Console.WriteLine($"1) Cadastrar CLiente");
Console.WriteLine($"2) Depositar");
Console.WriteLine($"3) Sacar");
Console.WriteLine($"4) Transferir");
Console.WriteLine($"5) Listar Clientes");
Console.WriteLine($"0) Sair");

Console.WriteLine($"Opção: ");
opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarCLiente();
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
            ListarClientes();
            break;

        case 0:
            Sair();
            break;

        default:
            break;
    }

Console.WriteLine($"Pressione <Enter> para continuar");
Console.ReadLine();


} while (opcao != 0);


void CadastrarCLiente()
{

    if (totalClientes >= 10)
        {
            Console.WriteLine($"Não há espaço para cadastrar");
            return;
            }

    Console.WriteLine($"Digite o nome do cliente.");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;

    Console.WriteLine($"Cliente Cadastrado com sucesso!");
    }


void Depositar()
{
        // retorna o indice do array onde o cliente esta armazenando
        int idCliente = BuscarCliente();

    if (idCliente == -1  )
        {
            return;
        }
    Console.WriteLine($"Valor para deposito: ");
    float valor = float.Parse(Console.ReadLine());
    saldos[idCliente] += valor;
    Console.WriteLine($"deposito de R$ {valor} realizado");
}

void Sacar()
{
    //buscar cliente e devolver o id dele
    // valida se nao existir, retorn vazio
    //informa a mensagem "valor para sque"
    //armazena o valor da variavel valor
    //se o saldo do cliente for maior ou igual ao valor
    //debita o valor
    //informe a mensagem "saque realizado com sucesso
    // se nao, informa que "saldo insuficiente"

    int idCliente = BuscarCliente();


        if (idCliente == -1)
        {
            return;
            }
    Console.WriteLine($"informe o valor para saque: ");
    float valor = float.Parse(Console.ReadLine());

        if (saldos[idCliente] >= valor && valor > 0)
        {
            saldos[idCliente] -= valor;
            Console.WriteLine($"Saque realizado com sucesso");
            }
            
            
        else
        {
            Console.WriteLine($"Saldo insuficiente");
            }

}

void Transferir()
{
    Console.WriteLine($"Função Transferir em desenvolvimento");

    Console.WriteLine($"== Transferencia ==");
    Console.WriteLine($"Conta de origem: ");
    int idOrigem = BuscarCliente();

        if (idOrigem == -1) return;

    Console.WriteLine($"Conta de destino: ");
    int idDestino = BuscarCliente();

        if (idOrigem == -1) return;

    Console.WriteLine($"Valor para transferir: ");
    float valor = float.Parse(Console.ReadLine());

        if (saldos[idDestino] >= valor  && valor > 0)
        {
            saldos[idOrigem] -= valor;
            saldos[idDestino] += valor;

            Console.WriteLine($"Tranferencia concluida!");
            }
            
        else
        {
            Console.WriteLine($"saldo insuficiente");
            }

}

void ListarClientes()
{

    for (var i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nomes[i]} | saldo: R${saldos[i]}");
        }
}

int BuscarCliente ()
{
    ListarClientes();

    Console.WriteLine($"Digite o numero do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());
        if (idCliente < 0 || idCliente >= totalClientes)
        {
            Console.WriteLine($"Cliente nao encontrado");
        return -1;
            }
            
    return idCliente;
}

void Sair()
{
    Console.WriteLine($"Saindo...");
}