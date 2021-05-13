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
            
            Console.WriteLine(ContaCorrente.TaxaOperacao);
            try
            {
                ContaCorrente conta = new ContaCorrente(274, 12345);
                ContaCorrente conta2 = new ContaCorrente(2345, 128984);

                conta.Transferir(10000, conta2);
            }
            catch (ArgumentException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
            }
            catch(OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
            }

            Console.ReadLine();
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("O resultado da divisao de 10 por " + divisor + " é " + resultado);          
        }

        private static int Dividir(int v, int divisor)
        {
            return v / divisor;
        }
    }
    
}
