using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX02
{
    public class Relatorio : IImprimivel
    {
        public string NomeResponsavel;
        public string TextoRelatorio;
        private string? responsavel;
        private string? empresa;
        private string? descricao;

        public Relatorio(string? responsavel, string? empresa, string? descricao)
        {
            this.responsavel = responsavel;
            this.empresa = empresa;
            this.descricao = descricao;
        }

        public void Imprimir()
        {
           Console.WriteLine($@"
        Responsavel: {responsavel} {NomeResponsavel}
        Empresa: {empresa}
        Descrição relatorio: {descricao}
                    ");
        }
    }
}