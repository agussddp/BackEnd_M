using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXheranca
{
     public class Carro : Veiculo
    {
        public int QtdPortas;

        public void MostrarInfo()
        {
            Console.WriteLine($"A marca do veículo é {Marca}, o modelo é {Modelo} e a quantidade de portas é {QtdPortas}!");

        }
    }
}