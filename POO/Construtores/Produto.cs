// Classe Produto:
// Crie uma classe Produto com atributos nome, preco e estoque.
// Crie um construtor que receba os valores e um método que mostre os dados.

public class Produto
    {
        string Nome;

        float Preco;

        int Estoque;


        public Produto(string n, float p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        public void ExibirDados()
        {
            Console.Clear();
            Console.WriteLine($"O produto é {Nome}, o preço é {Preco} e a quantidade em estoque é {Estoque}!");
            
        }

    }