using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Au au au au");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"ploc ploc ploc");
            
        }
    }
}