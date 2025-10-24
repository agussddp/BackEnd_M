string  [] nomes    = new string[3];
int     [] idades   = new int   [3];
int totalalunos = 0;

int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine("==== Aplicativo Sala de Aula ====");
    Console.WriteLine($"1) Listar Alunos");
    Console.WriteLine($"2) Cadastrar alunos");
    Console.WriteLine($"0) Sair");

    Console.WriteLine($"Escolha um opcao");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando");
            break;

        case 1:
            listaraluno();
            break;

        case 2:
            cadastraraluno();
            break;
    }
     
        Console.WriteLine($"Digite <Enter> para continuar");
        Console.ReadLine();
        
        
} while (opcao != 0);


void listaraluno ()

{
    Console.WriteLine("==== Listagem de Alunos ====");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"{nomes[i]}, {idades[i]} anos");   
    }
    
    
}

void cadastraraluno ()
{
    Console.WriteLine("==== Cadastro de Alunos ====");

    if (totalalunos >= 3)
    {
        Console.WriteLine($"limite de vagas atingido");
        return;
    }

    Console.WriteLine($"Digite o nome to aluno");
    nomes[totalalunos] = Console.ReadLine();
    

    Console.WriteLine($"Digite a idade de {nomes[totalalunos]}");
    idades[totalalunos] = int.Parse(Console.ReadLine());
    totalalunos++;

    Console.WriteLine($"Aluno Cadastrado com sucesso!");
    
}