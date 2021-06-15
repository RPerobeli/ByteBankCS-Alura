using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 123456);

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Agencia);

            conta.Sacar(50);

            Console.ReadLine();
        }
    }
}
