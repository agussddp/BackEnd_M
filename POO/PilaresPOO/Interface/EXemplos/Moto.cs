using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXemplos
{
    public class Moto : IMotor
    {

        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;


        public Moto(string C, string M, string Mo, int A)
        {
            Cor = C;
            Marca = M;
            Modelo = Mo;
            Ano = A;
        }


         public void ExibirInfo()
            {
                Console.WriteLine($@"Informações do Veículo:
                Cor:    {Cor}  
                Marca:  {Marca} 
                Modelo: {Modelo} 
                Ano:    {Ano}");
            }
    


        public void Acelerar()
        {
            Console.WriteLine($"Moto acelerando... Vruummmmmmmm");
        }

        public void freiando()

        {
            Console.WriteLine($"Moto freiando... iiiiiiiirrrrrrrrhhhhhh");
        }

        public void Frear()
        {
            throw new NotImplementedException();
        }
    }
}