using Exemplos;

// Gato Mari = new Gato();
// Mari.FazerSom();
// Mari.Mover();

// Cachorro Nina = new Cachorro();
// Nina.FazerSom();
// Nina.Mover();

// Pessoa Giu = new Pessoa();
// Giu.Nome = "Giulia";
// Giu.Idade = 17;
// Giu.Mover();
// Giu.FazerSom();
// Giu.ExibirDetalhes();


Console.Clear();

ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da conta: R${cc.Saldo}");
cc.Depositar(0.5);

Console.WriteLine($"Saldo após depósito: R${cc.Saldo}");
cc.Sacar(10);

Console.WriteLine($"Saldo após saque: R${cc.Saldo}");

Console.WriteLine($"");



ContaPoupanca cp = new ContaPoupanca(10);
Console.WriteLine($"Saldo inicial da conta: R${cp.Saldo}");
cp.Depositar(0.5);

Console.WriteLine($"Saldo após depósito: R${cp.Saldo}");
cp.Sacar(10);

Console.WriteLine($"Saldo após saque: R${cp.Saldo}");