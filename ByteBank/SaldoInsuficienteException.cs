using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo {get;}
        public double Valor {get;}
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string mensagem) : base(mensagem) { }
        public SaldoInsuficienteException(double saldo, double valor) : this("Tentativa de retirada de " + valor + " com saldo de " + saldo)
        {
            Saldo = saldo;
            Valor = valor;
        }
    }
}
