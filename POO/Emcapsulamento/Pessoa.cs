using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emcapsulamento
{
    public class Pessoa
    {

        //Propriedades
        public string Nome
        {
            get
            {
                if (Altura > 0)
                {
                    return Nome;
                }
                return "";

            }
            private set { }
        }
        public int Massa { get; private set; }
        public double Altura { get; private set; }
        public double IMC { get; private set; }

        //Construtor
        public Pessoa(string n, int m, double a)
        {
            Nome = n;
            Massa = m;
            Altura = a;
        }


        //Métodos
        private void CalcularIMC()
        {
            IMC = Massa / (Altura * Altura);
        }


        public void ExibirDados()
        {
            CalcularIMC();

            Console.WriteLine($"Nome: {Nome} | Massa: {Massa} | Altura: {Altura}");

            Console.WriteLine($"O IMC de {Nome} é {IMC:F2}");

        }
    }
}
