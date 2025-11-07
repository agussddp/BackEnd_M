// LISTA DE EXERCÍCIOS – CONSTRUTORES E SOBRECARGA

// Classe Carro:
// Crie uma classe Carro com os atributos marca, modelo e ano.
// Faça um construtor que receba esses três valores e exiba os dados do carro.


namespace Construtores
{
    public class Carro
    {
        public string Modelo;
        public string Marca;
        public int Ano;


        public Carro(string M, string A, int N)
        {
            Marca = M;
            Modelo = A;
            Ano = N;
        }

        public void ExibirDados()
        {
            
            Console.WriteLine($"Modelo: {Modelo}, Marca: {Marca} e Ano: {Ano}");
        }

    }
}