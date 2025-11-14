using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXheranca
{
    
            public class Gerente : Funcionario
    {
      public float BonusAdicional;


        public override float CalcularSalario()
        {
            return SalarioBase + BonusAdicional;
        }
    }

    }