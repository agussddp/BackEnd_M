using System;

using EXEmcapsulamento;
class Program
{
    static void Main(string[] args)
    {
        Carro meuCarro = new Carro();

        meuCarro.DefinirMarca("Toyota");
        meuCarro.DefinirModelo("Corolla");


        // Acelerações
        meuCarro.Acelerar(30);
        meuCarro.Acelerar(20);

        // Frenagens
        meuCarro.Frear(10);
        meuCarro.Frear(50); // Teste: não pode ficar negativo

        // Exibição
        Console.WriteLine($"Marca: {meuCarro.ObterMarca()}");
        Console.WriteLine($"Modelo: {meuCarro.ObterModelo()}");
        Console.WriteLine($"Velocidade Atual: {meuCarro.ObterVelocidade()} km/h");
    }
}
