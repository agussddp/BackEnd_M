//   Escreva     um     programa     que     verifique     a     validade     de   
//   uma     senha     fornecida pelo     usuário.     A     senha     válida     é     
//   o     número     1234.    Devem     ser    impressas     as    seguintes     mensagens:     

//ACESSO    PERMITIDO    caso    a    senha    seja    válida.     
// ACESSO    NEGADO    caso    a    senha    seja    inválida

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
