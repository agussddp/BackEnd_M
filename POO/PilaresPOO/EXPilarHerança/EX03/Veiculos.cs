using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXheranca
{
    public class Veiculo
    {
        public string Marca;

        public string Modelo;

        public void MostrarInfo()
        {
            Console.WriteLine($"A marca do veículo é {Marca} e o modelo é {Modelo}!");
            
        }
    }
}