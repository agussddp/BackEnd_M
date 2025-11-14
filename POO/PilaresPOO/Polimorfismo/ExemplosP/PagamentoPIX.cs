using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosP
{
    public class PagamentoPix : Pagamento
    {
        private float desconto = 5;

        public float ValorCompra;

        public override float CalcularTotal()
        {
            float valorDesconto = ValorCompra / 100 * desconto;
            return ValorCompra = ValorCompra - valorDesconto;
        }
    }
}