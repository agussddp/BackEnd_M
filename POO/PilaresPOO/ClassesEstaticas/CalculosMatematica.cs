namespace ClassesEstaticas
{
    public class CalculosMatematica
    {
        public static double PI = 3.14159265359;

        public static float Somar(float x, float y)
        {
            float resultado = x + y;
            Console.WriteLine($"Soma é: {resultado}");
            return resultado;
        }

        public static float Subtrair(float x, float y)
        {
            float resultado = x - y;
            Console.WriteLine($"Subtração é: {resultado}");
            return resultado;
        }

        public static float Multiplicar(float x, float y)
        {
            float resultado = x * y;
            Console.WriteLine($"Multiplicação é: {resultado}");
            return resultado;
        }

        public static float Dividir(float x, float y)
        {
            if (y == 0)
            {
                Console.WriteLine("Divisão inválida (não é possível dividir por zero).");
                return 0; 
            }

            float resultado = x / y;
            Console.WriteLine($"Divisão é: {resultado}");
            return resultado;
        }

       
    }
}
    

