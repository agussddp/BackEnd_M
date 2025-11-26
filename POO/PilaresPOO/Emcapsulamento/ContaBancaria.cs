namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
            {
                Saldo = 0;
            }
        }

        public float GetSaldo()
        {
            return Saldo;
        }

        public void Depositar(float valor)
        {
            if (valor <= 0)   // Corrigido: só aceita depósitos positivos
            {
                Console.WriteLine($"Saldo invalido");
            }
            else
            {
                
                Saldo += valor;
            }
        }

        public void Sacar(float valor)
        {
            if (valor > 0 && valor <= Saldo)  // Evita saldo negativo
            {
                Saldo -= valor;
                Console.WriteLine($"Saque efetuado com sucesso!");
            }

            else
            {
                Console.WriteLine($"Saldo insuficiente ou negativo!");
            }
        }
    }
}
