
using System.Reflection.Metadata;
using EX02;

// //criar lista para faturas\
// List<Fatura> listaFaturas = new List<Fatura>();
// List<Contrato> listaContratos = new List<Contrato>();
// List<Relatorio> listaRelatorios = new List<Relatorio>();


// //cria um objeto de cada classe e adiciona nas listas
// Fatura fatMaria = new Fatura();
// listaFaturas.Add(fatMaria); //guardar qualquer intem que seja da classe 

// Fatura fatXuxu = new Fatura();
// listaFaturas.Add(fatXuxu);
// //------

// Relatorio relMaria = new Relatorio();
// listaRelatorios.Add(relMaria);

// Relatorio relXuxu = new Relatorio();
// listaRelatorios.Add(relXuxu);
// //---

// Contrato conMaria = new Contrato();
// listaContratos.Add(conMaria);

// Contrato conXuxu = new Contrato();
// listaContratos.Add(conXuxu);

// // fatMaria.Imprimir();
// // relMaria.Imprimir();
// // conMaria.Imprimir();


// //listar os dados da fatura

// foreach (var Fatura in listaFaturas)
// {
//     Fatura.Imprimir();
// }

// foreach (var Relatorio in listaFaturas)
// {
//     Relatorio.Imprimir();
// }

// foreach (var Contrato in listaContratos)
// {
//     Contrato.Imprimir();
// }





List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.Write($@"
    Menu de opções:

1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Listar Contratos
0) Sair
Escolha a opção:
");
opcao = int.Parse(Console.ReadLine());



// criar um switch para as opcoes do menu

switch (opcao)
{
    case 1:
        CadastrarFaturas();
        break;

    case 2:
        CadastrarRelatorios();
        break;

    case 3:
    CadastrarContratos();
        break;

    case 4:
    ListarFaturas();
        break;

    case 5:
    ListarRelatorios();
        break;

    case 6:
    ListarContratos();
        break;

    case 0:
    Console.WriteLine($"Saindo... Volte logo!");
        break;

    default:
    Console.WriteLine($"Opção inválida!");
    
        break;
}

Console.WriteLine($"Precione <ENTER> para continuar");
Console.ReadLine();


} while (opcao != 0);


//funções


//Faturas
void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do cliente devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura");
    float valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Digite os dias de atraso da fatura");
    int qtdAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(dev, empresa, valor, qtdAtraso);
    documentos.Add(fat);

    Console.WriteLine("Fatura cadastrada com sucesso!");

    	    }
void ListarFaturas()
{
    Console.WriteLine($"Listando faturas");
    
    foreach (var item in documentos)
    {
        if(item is Fatura)
        {
            item.Imprimir();
        }  
    }
}


//Contratos
void CadastrarContratos()
{
   Console.WriteLine("Digite o nome do contratante");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite o texto das cláusulas do contrato");
    string clausulas = Console.ReadLine();

    //criar um objetoda classe contrato
    Contrato contrato = new Contrato();
    contrato.Nome = nome;
    contrato.TextoClausulas = clausulas;

    // cadastrar o contrato na lista de documentos
    documentos.Add(contrato);
    Console.WriteLine("Contrato cadastrado com sucesso!");
}
void ListarContratos()
{
     Console.WriteLine($"Listando contratos");
    
    foreach (var item in documentos)
    {
        if(item is Contrato)
        {
            item.Imprimir();
        }  
    }
}




//Relatorios
void CadastrarRelatorios()
{
    Console.WriteLine($"Digite o nome do responsável");
    string responsavel = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite a descrição do relatório");
    string descricao = Console.ReadLine();

    Relatorio rel = new Relatorio(responsavel, empresa, descricao);
    documentos.Add(rel);

    Console.WriteLine("Relatório cadastrado com sucesso!");
}
void ListarRelatorios()
{
     Console.WriteLine($"Listando relatorios");
    
    foreach (var item in documentos)
    {
        if(item is Relatorio)
        {
            item.Imprimir();
        }  
    }
}







