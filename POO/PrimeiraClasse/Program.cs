using PrimeiraClasse;

Console.WriteLine($"==== PROGRAMA PRIMEIRA CLASSE ====");

// // Carro mclaren = new Carro();
// // mclaren.marca = "Mclaren";
// // mclaren.cor = "Laranja";
// // mclaren.modelo = "750s";
// // mclaren.potencia = 800;

// // Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}");
// // mclaren.Ligar();
// // Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia} cv");
// // mclaren.Acelerar();


// Pessoa edu = new Pessoa();
// edu.Nome = "Eduardo Mendes";
// edu.Idade = 43;
// edu.Altura = 166;

// edu.Falar();
// edu.Dormir();


// Garrafa Tupperware = new Garrafa();
// Tupperware.Cor = "Azul";
// Tupperware.Capacidade = 500;
// Tupperware.Tamanho = 27;
// Tupperware.Formato = "Arredondada";

Pessoa edu = new Pessoa();
edu.Nome = "Eduardo Mendes";
edu.Altura = 166;
edu.Envelhecer();

Console.WriteLine($"{edu.Nome} tem {edu.Idade}");
edu.Envelhecer();
Console.WriteLine($"{edu.Nome} tem {edu.Idade}");
