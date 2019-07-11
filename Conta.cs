using System.Globalization;

namespace banco
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public float Saldo { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, float valor) : this(numero, nome)
        {
            Saldo = valor;
        }

        public void Depositar(float valor)
        {
            Saldo += valor;
        }

        public void Sacar(float valor)
        {
            Saldo -= valor;
            Saldo -= 5.00f;
        }

        public override string ToString()
        {
            return "Numero: " + Numero
                + ",\nNome: " + Nome
                + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}
