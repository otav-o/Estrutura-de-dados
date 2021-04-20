using System;
using System.Collections.Generic;
using System.Text;

namespace ListasContiguas
{
    class ListaContigua
    {
        public void Adicionar(double valor)
        {
            Exception erro = new Exception("Lista cheia");

            if (tamanho >= TAMANHO_MAXIMO)
                throw erro;

            itens[tamanho] = valor;
            tamanho++;
        }

        public void RemoverNoFinal()
        {
            if (tamanho <= 0)
                throw new Exception("Não é possível remover um elemento de uma lista vazia.");

            tamanho--;
        }

        public double RetornarItem(int indice)
        {
            if (indice < 0 || indice >= tamanho)
                throw new ArgumentOutOfRangeException("O índice está fora dos limites da lista.");

            return itens[indice];

        }

        public double this[int indice] // this + colchetes: indexador (somente C#)
        {
            get
            {
                if (indice < 0 || indice >= tamanho)
                    throw new ArgumentOutOfRangeException("O índice está fora dos limites da lista.");

                return itens[indice];
            }
            set
            {
                if (indice < 0 || indice >= tamanho)
                    throw new ArgumentOutOfRangeException("O índice está fora dos limites da lista.");

                itens[indice] = value;
            }


        }

        public int Tamanho { get => tamanho; }

        private int tamanho = 0;
        private const int TAMANHO_MAXIMO = 100;
        private double[] itens = new double[100];
    }
}