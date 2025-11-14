using ExemplosP;

PagamentoPix compraPIX = new PagamentoPix();
compraPIX.ValorCompra = 15000;

float valorPagar = compraPIX.CalcularTotal();

Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"Preço: R${compraPIX.ValorCompra}");
Console.WriteLine($"Forma de pagamento: PIX");
Console.WriteLine($"Pagamento com desconto: R${valorPagar}");

Console.WriteLine();


PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao.ValorCompra = 50;

Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preço: R${compraCartao.ValorCompra}");
Console.WriteLine($"Forma de pagamento: Cartão");
Console.WriteLine($"Pagamento com acrescimo: R${compraCartao.CalcularTotal()}");
