using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX02
{
   public class Fatura : IImprimivel
    {
        public string Devedor;
        public string Credor;
        public float Valor;
        public int DiasAtraso;
        private float Juros= 0.10f;

        public Fatura(string nomeDevedor, string nomeEmpresa, float valorFatura, int qtdDiasAtraso)
        {
            Devedor = nomeDevedor;
            Credor = nomeEmpresa;
            Valor = valorFatura;
            DiasAtraso = qtdDiasAtraso;
        }

        public void CalcularValorDivida()
        {
            if (DiasAtraso > 0)
                {
                Valor = Valor + DiasAtraso * Juros;
            }

            if (DiasAtraso >= 5)
                {
                Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }

        public void Imprimir()
        {
        Console.WriteLine($@"
        Credor: {Credor}
        Devedor: {Devedor}
        Dias de Atraso: {DiasAtraso}
        Juros: R${Juros * DiasAtraso}
        Valor Total: R${Valor}
                    ");
        }
    }
}