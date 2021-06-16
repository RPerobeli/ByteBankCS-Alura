using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListLambdaLinq();
            Console.ReadLine();
        }
        static void ListLambdaLinq()
        {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            //ListExtensoes.AdicionarVarios(idades, 444,555,654,789);
            idades.AdicionarVarios(444, 555, 777);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }
        static void ContaCorrente()
        {
            ContaCorrente conta = new ContaCorrente(345, 12345);
            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
        static void DateTime()
        {
            //DateTime dataFimPagamento = new DateTime(2021, 6, 15);
            //DateTime dataCorrente = DateTime.Now;

            //TimeSpan diff = dataFimPagamento - dataCorrente;
            //string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diff);
            //Console.WriteLine(mensagem);
        }
        static void Strings()
        {
            
            string url = "paginas?argumentos";
            int indiceInterrocacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrocacao);
            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrocacao + 1);
            Console.WriteLine(argumentos);

            string url2 = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            ExtratorValorArgumentoURL extrator = new ExtratorValorArgumentoURL(url2);
            Console.WriteLine(extrator.GetValor("moedaOrigem"));
            Console.WriteLine(extrator.GetValor("moedaDestino"));
        }
        static void RegularExpressions()
        {
            //Regular Expressions
            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao2 = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao3 = "[0-9]{4}[-][0-9]{4}";
            //string padrao4 = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}[-]?[0-9]{4}";
            string teste = "Olá, meu nome é rodrigo, me encontre em: 3216-3521";
            Console.WriteLine(Regex.IsMatch(teste, padrao));

            Match resultado = Regex.Match(teste, padrao);
            Console.WriteLine(resultado);
        }
        static void Arrays()
        {
            ListaContaCorrente lista = new ListaContaCorrente();
            ContaCorrente contaDoPerobeli = new ContaCorrente(123,12345);

            lista.Adicionar(new ContaCorrente(345, 23462));
            lista.Adicionar(new ContaCorrente(363, 22451));
            lista.Adicionar(contaDoPerobeli);
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Remover(contaDoPerobeli);

            lista.EscreverListaNaTela();

            //ContaCorrente conta = lista.GetItemNoIndice(2);
            //Console.WriteLine($"{conta.Agencia}/{conta.Numero}");

            for (int i = 0; i < lista.Tamanho; i++)
            {
                //ContaCorrente conta = lista.GetItemNoIndice(i);
                ContaCorrente conta = lista[i];
                Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
            }

            ContaCorrente[] contas = new ContaCorrente[]
{
                new ContaCorrente(100, 40010),
                new ContaCorrente(101, 40011),
                new ContaCorrente(102, 40012),
                new ContaCorrente(103, 40013)
            };
            lista.AdicionarVarios(
                new ContaCorrente(100, 40010),
                new ContaCorrente(101, 40011),
                new ContaCorrente(102, 40012),
                new ContaCorrente(103, 40013)
                );
        }
    }
}
