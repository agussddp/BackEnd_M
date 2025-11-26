using ClassesEstaticas;

// CalculosMatematica calc = new CalculosMatematica();

// Console.WriteLine($"Número PI: {CalculosMatematica.PI}");
// Console.WriteLine($"Soma de 5 e 10: {CalculosMatematica.Somar(5, 10)}");


// // criar outras 3 ops e fazer a chamada aqui no programa
// // nao esqueca de validar a divisao por zero

// Console.WriteLine($"Digite o primeirp numero:");
// float n1 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo numero:");
// float n2 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Resultaos:");

// Console.WriteLine($"Soma: {CalculosMatematica.Somar(n1,n2)}");
// Console.WriteLine($"Subtração: {CalculosMatematica.Subtrair(n1,n2)}");
// Console.WriteLine($"Multiplicação: {CalculosMatematica.Multiplicar(n1,n2)}");
// Console.WriteLine($"Divisão: {CalculosMatematica.Dividir(n1,n2)}");

//solicitar dois numeros reais e informar qual o maior e o menor. utilizar class mathcutilitaria do c#


  
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Maior número: {Math.Max(num1, num2)}");
        Console.WriteLine($"Menor número: {Math.Min(num1, num2)}");
    