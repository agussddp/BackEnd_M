// No Círculo utilizar o cálculo = PI * Raio * Raio;

namespace EX01
{
    public class Circulo : IForma
    {
        public double Raio;
        public double Area;



       

         public void CalcularArea()
        {
           Area =  Math.PI * (Raio * 2); 
           Console.WriteLine($"Area do Circulo é igual a: {Area}");
                }
    }
}