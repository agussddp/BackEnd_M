using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXheranca
{
     public class Moto : Veiculo
    {
        public string TipoDeCapacete;

        public void MostrarInfo()
        {
            Console.WriteLine($"A marca do veículo é {Marca}, o modelo é {Modelo} e o tipo de capacete é {TipoDeCapacete}!");

        }
    }
       
}