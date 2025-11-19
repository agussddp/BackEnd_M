
// No Retângulo utilizar o cálculo = Largura * Altura;


namespace EX01
{
    public class Retangulo : IForma
    {
        public double Altura;
        public double Largura;
        public double Area;

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
                }

        public void CalcularArea()
        {
           Area =  Largura * Altura;
           Console.WriteLine($"Area do retangulo é igual a: {Area}");
        }
    }
}