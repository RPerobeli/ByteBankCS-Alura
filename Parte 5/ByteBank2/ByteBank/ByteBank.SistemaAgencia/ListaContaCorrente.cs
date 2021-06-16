using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaContaCorrente
    {
        private ContaCorrente[] _items;
        private int _proxPosicao;
        public ListaContaCorrente(int capacidadeInicial = 5)
        {
            _items = new ContaCorrente[capacidadeInicial];
            _proxPosicao = 0;

        }

        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proxPosicao+1);
            Console.WriteLine($"Adicionando no índice {_proxPosicao} conta {item.Agencia}/{item.Numero}");
            _items[_proxPosicao] = item;
            _proxPosicao++;

        }
        private void VerificarCapacidade(int novaCapacidade)
        {
            if (_items.Length >= novaCapacidade)
            {
                return;
            }
            int novoTamanho = 2 * _items.Length;
            Console.WriteLine("Aumentando capacidade da lista!");
            if (novoTamanho < novaCapacidade)
            {
                novoTamanho = novaCapacidade;
            }
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];
            for(int i =0;i<_items.Length;i++)
            {
                novoArray[i] = _items[i];
            }
            _items = novoArray;
        }
        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for(int i = 0; i<_proxPosicao;i++)
            {
                if(_items[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                } 
            }
            for (int i = indiceItem; i < _proxPosicao - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _proxPosicao--;
            _items[_proxPosicao] = null;
        }
        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proxPosicao; i++)
            {
                ContaCorrente conta = _items[i];
                Console.WriteLine($"Conta no índice {i}: numero {conta.Agencia} {conta.Numero}");
            }
        }
        public ContaCorrente GetItemNoIndice(int indice)
        {
            if(indice < 0 || indice > _proxPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _items[indice];
        }

        public int Tamanho
        { 
            get
            {
                return _proxPosicao;
            }
        }
        public ContaCorrente this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }

        public void AdicionarVarios(params ContaCorrente[] contas)
        {
            
        }
    }
}
