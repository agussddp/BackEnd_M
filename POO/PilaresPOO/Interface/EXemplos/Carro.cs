using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXemplos
{
    public class Carro : IMotor

    {
        public string Cor;
        public string Marca;
        public string Modelo;
        int Ano;


            //Construtores
            public Carro(string C, string M, string Mo, int A)
        {
            Cor = C;
            Marca = M;
            Modelo = Mo;
            Ano = A;
        }

            //Metodos
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
           Console.WriteLine($"Carro acelerando... Vrum vrum");
           
        }

        public void Frear()
        {
            Console.WriteLine($"Carro freiando... irrrrrh ");
            
        }
    }
}