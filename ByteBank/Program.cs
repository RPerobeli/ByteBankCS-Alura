using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(7480, 874150);
            //Console.WriteLine(ContaCorrente.TaxaOperacao);
            TestaDivisao(0);
            Console.ReadLine();
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("O resultado da divisao de 10 por " + divisor + " é " + resultado);
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Não é possivel dividir por 0!");
            }
            
        }

        private static int Dividir(int v, int divisor)
        {
            return v / divisor;
        }
    }
    
}
