using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXemplos
{
    public interface IControle
    {
        public void Ligar();
        public void Desligar();
        public void AumentarVol();
        public void DominuirVol();
    }
}