

namespace Calculadora
{
    public class Calculator
    {
        //Atributos
        //n1, n2 e resultado
        public double n1;
        public double n2;
        public double resultado;

        //Métodos
        public double Somar()
        {
            resultado = n1 + n2;
            return resultado;
        }
        public double Multiplicar()
        {
            resultado = n1 * n2;
            return resultado;
        }
        public double Subtrair()
        {
            resultado = n1 - n2;
            return resultado;
        }
        public double Dividir()
        {
            if (n2 == 0)
            {
                Console.WriteLine($"Não existe divisão por zero");
                return -1;
                 }
            resultado = n1 / n2;
            return resultado;
        }

    }
}