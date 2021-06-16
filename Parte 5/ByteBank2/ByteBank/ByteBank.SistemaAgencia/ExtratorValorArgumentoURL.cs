using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorArgumentoURL
    {
        private readonly string _argumentos;
        public string URL {get;}
        public ExtratorValorArgumentoURL(string url)
        {
            if(String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento não pode ser nulo ou vazio", nameof(url));
            }
            URL = url;
            int indInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indInterrogacao + 1);
        }
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro + "=";
            int indice = _argumentos.IndexOf(nomeParametro);

            int indiceValor = indice + nomeParametro.Length;

            string valorArgumento = _argumentos.Substring(indiceValor);
            int indiceFim = valorArgumento.IndexOf('&');
            if(indiceFim != -1)
            {
                valorArgumento = valorArgumento.Remove(indiceFim);
            }
            return valorArgumento;
        }
    }
}
