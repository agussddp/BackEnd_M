using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXheranca
{
        public class Funcionario
    {
       public string Nome;

        public float SalarioBase = 1500f;


    public virtual float CalcularSalario()
        {
            return SalarioBase;
        }
    }

}
