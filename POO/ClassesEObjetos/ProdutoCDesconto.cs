using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Crie uma classe Produto com os atributos nome e preco.
// Crie um método AplicarDesconto(double percentual) que reduza o preço do produto com base no valor do desconto.
// Depois mostre o novo preço no console.

namespace ClassesEObjetos
{
    public class ProdutoCDesconto
    {
        public string Nome;

        public double Preco;

        public void AplicarDesconto(double percentual)
        {
            if (percentual > 0 && percentual <= 50)
            {
                double valorDesconto = Preco * (percentual / 100);
                Preco -= valorDesconto;
                Console.WriteLine($"Desconto de {percentual}% foi aplicado, o preco aatual eh R${Preco}");
            }
            else
                {
                Console.WriteLine($"Percentual de desconto invalido");
                }



        }


    }
}