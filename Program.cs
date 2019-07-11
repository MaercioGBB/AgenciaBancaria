using System;
using System.Globalization;

namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;
            Console.Write("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            string nome = Console.ReadLine();
            Console.Write("Vai depositar (s/n): ");
            char opcao = char.Parse(Console.ReadLine());
            if(opcao == 's' || opcao == 'S')
            {
                Console.Write("Qual valor: ");
                float valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, nome, valor);
            }
            else
            {
                c = new Conta(numero, nome);
            }

            Console.WriteLine(c);
            Console.Write("\nValor deposito: ");
            float val = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(val);
            Console.WriteLine(c);
            Console.Write("\nValor saque: ");
            val = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(val);
            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(c);
        }
    }
}
