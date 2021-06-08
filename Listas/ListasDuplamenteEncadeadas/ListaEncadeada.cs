using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplesmenteEncadeadas
{
    class ListaEncadeada<T>
    {
        public void AdicionarNoInicio(T valor)
        {
            var novoNo = new No<T> { Valor = valor };

            if (primeiro == null)
            {
                primeiro = novoNo;
                ultimo = novoNo;
            }
            else
            {
                novoNo.Proximo = primeiro;
                primeiro.Anterior = novoNo; // !
                primeiro = novoNo;
            }

        }

        public void AdicionarNoFinal(T valor)
        {
            var novoNo = new No<T> { Valor = valor };

            if (primeiro == null)
            {
                primeiro = novoNo;
                ultimo = novoNo;
            }
            else
            {
                ultimo.Proximo = novoNo;
                novoNo.Anterior = ultimo; // !
                ultimo = novoNo;
            }
        }

        public void RemoverNoInicio()
        {
            if (primeiro == null)
                throw new Exception("A lista está vazia!");

            if (primeiro == ultimo)
                primeiro = ultimo = null;
            else
            {
                primeiro.Proximo.Anterior = null; // !
                primeiro = primeiro.Proximo;
            }
        }

        public void RemoverNoFinal()
        {
            if (primeiro == null)
                throw new Exception("A lista está vazia!");
            else if (primeiro.Proximo == null)
                primeiro = ultimo = null;
            else
            {
                ultimo = ultimo.Anterior;
                // ultimo.Anterior.Proximo = null;
                ultimo.Proximo = null;
            }
        }

        public void ParaCada(Action<T> imprimir)
        {
            var atual = primeiro;

            while (atual != null)
            {
                imprimir(atual.Valor);
                atual = atual.Proximo;
            }
        }

        private No<T> primeiro;
        private No<T> ultimo;
    }
}
