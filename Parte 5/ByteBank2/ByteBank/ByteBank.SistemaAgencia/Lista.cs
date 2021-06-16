using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
    {
        private T[] _items;
        private int _proxPosicao;
        public Lista(int capacidadeInicial = 5)
        {
            _items = new T[capacidadeInicial];
            _proxPosicao = 0;

        }

        public void Adicionar(T item)
        {
            VerificarCapacidade(_proxPosicao + 1);
            //Console.WriteLine($"Adicionando no índice {_proxPosicao} conta {item.Agencia}/{item.Numero}");
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
            T[] novoArray = new T[novoTamanho];
            for (int i = 0; i < _items.Length; i++)
            {
                novoArray[i] = _items[i];
            }
            _items = novoArray;
        }
        public void Remover(T item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proxPosicao; i++)
            {
                if (_items[i].Equals(item))
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
            //_items[_proxPosicao] = null;
        }
        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proxPosicao; i++)
            {
                T item = _items[i];
                Console.WriteLine(item);
            }
        }
        public T GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice > _proxPosicao)
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
        public T this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }

        public void AdicionarVarios(params T[] contas)
        {
            foreach (T c in contas)
            {
                Adicionar(c);
            }
        }
    }
}
