using System;
using System.Collections.Generic;
using System.Text;

namespace Resposta
{
    class ListaEncadeada
    {
        public void AdicionarNoInicio(int valor)
        {
            var novoNo = new No { Valor = valor };
            if (primeiro == null)
                primeiro = novoNo;
            else
            {
                novoNo.Proximo = primeiro;
                primeiro = novoNo;
            }
            tamanho++;
        }

        public void AdicionarNoFinal(int valor)
        {
            var novoNo = new No { Valor = valor };

            if (primeiro == null)
                primeiro = novoNo;
            else
            {
                var no = primeiro;

                while (no.Proximo != null)
                    no = no.Proximo;
            }
            tamanho++;
        }

        public void RemoverNoInicio()
        {
            if (primeiro == null)
                throw new Exception("Lista vazia.");

            if (primeiro == ultimo)
            {
                primeiro = null;
                ultimo = null;
            }
            else
                primeiro = primeiro.Proximo;

            tamanho--;
        }

        public void RemoverNoFinal()
        {
            // elemento.proximo.proximo == null; aí remove o elemento.proximo

            if (primeiro == null)
                throw new Exception("Lista vazia.");

            if (primeiro == ultimo)
                primeiro = ultimo = null;

            else
            {
                var penultimo = primeiro;
                while (penultimo.Proximo.Proximo != null)
                    penultimo = penultimo.Proximo;

                penultimo.Proximo = null;
                ultimo = penultimo;

            }
            tamanho--;

        }

        public int Tamanho => tamanho; // propriedade get
        public No Primeiro { get; }
        private No primeiro;
        private No ultimo;
        private int tamanho;
    }
}
