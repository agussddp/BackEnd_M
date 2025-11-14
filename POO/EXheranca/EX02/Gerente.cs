using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXheranca
{
    
            public class Gerente : Funcionario
    {
        public float BonusAdicional;
        public float SalarioNovo;

        public void CalcularSalario()
        {
           SalarioNovo = SalarioBase + BonusAdicional;
        }

        public void ExibirSalario()
        {
            Console.WriteLine($"O salário do {Nome} é: R${SalarioNovo}");
        }
    }

    }
