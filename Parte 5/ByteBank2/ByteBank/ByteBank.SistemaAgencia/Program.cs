using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(345, 12345);
            //Console.WriteLine(conta.Numero);
            //Console.ReadLine();

            DateTime dataFimPagamento = new DateTime(2021, 6, 15);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diff = dataFimPagamento - dataCorrente;
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diff);

            Console.WriteLine(mensagem);
            Console.ReadLine();

        }
    }
}
