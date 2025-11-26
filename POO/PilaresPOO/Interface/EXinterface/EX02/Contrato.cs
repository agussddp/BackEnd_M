using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX02
{
    public class Contrato : IImprimivel
    {
        public string Nome;
        public string TextoClausulas;
        public void Imprimir()
        {
            Console.WriteLine($@"
        Responsavel: {Nome}
        Descrição relatorio: {TextoClausulas}
         ");
        }
    }
}

//fazer a funcaob de cadastrar e listar os relatorios