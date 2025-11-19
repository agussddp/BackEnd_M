// Exercício 1
// Crie uma interface chamada IForma com o método CalcularArea.
// Crie duas classes que implementem essa interface: Retangulo e Circulo.
// No programa, peça os valores necessários e exiba a área calculada para cada forma.

using EX01;

Console.WriteLine($"                      =====      ");
Console.WriteLine($"                  ============      ");
Console.WriteLine($"           =========================");
Console.WriteLine($"-------==================================--------");
Console.WriteLine($"----=== Bem vindo ao programa de Geometria ===----");
Console.WriteLine($"-------==================================--------");
Console.WriteLine($"           =========================");
Console.WriteLine($"                  ============      ");
Console.WriteLine($"                      =====      ");

Console.WriteLine();
Console.WriteLine();


// AREA DO RETANGULO
Console.WriteLine($"   =========================");
Console.WriteLine($"----=== AREA DO RETANGULO ----===");
Console.WriteLine($"   =========================");
Console.WriteLine();


Console.WriteLine($"Vamos calcular a área do retângulo:");

Console.WriteLine($"Informe a altura");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe a Largura");
double largura = double.Parse(Console.ReadLine());
Console.WriteLine();


//cria a variavel objeto da classe retangulo
Retangulo retangulo = new Retangulo(altura, largura);
Console.WriteLine();



//            =========================
//-------==================================--------
//----=========================================----
//-------==================================--------
//            =========================


// AREA DO CIRCULO
Console.WriteLine($"   =========================");
Console.WriteLine($"----=== AREA DO CIRCULO ----===");
Console.WriteLine($"   =========================");
Console.WriteLine();


Console.WriteLine($"Agora vamos calcular a área do circulo:");
Console.WriteLine($"Informe o raio do circulo");
double Raio = double.Parse(Console.ReadLine());
Console.WriteLine();



//cria a variavel objeto da classe retangulo
Circulo circulo = new Circulo();
circulo.Raio = Raio;



//RESULTADOS

Console.WriteLine($"  =========================");
Console.WriteLine($"----=== RESULTADOS ----===");
Console.WriteLine($"  =========================");
Console.WriteLine();


retangulo.CalcularArea();
circulo.CalcularArea();

Console.WriteLine();
