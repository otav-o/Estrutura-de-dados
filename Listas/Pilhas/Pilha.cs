using System;
using System.Collections.Generic;
using System.Text;

namespace Pilhas
{
    class Pilha
    {
        public void AdicionarNoInicio(int numero)
        {
            ultimo = new No(numero);
        }

        public void RemoverNoInicio()
        {
            if (ultimo == null)
                throw new Exception("Pilha vazia");

            ultimo = ultimo.Proximo;
        }

        public int? RetornaValorTopo()
        {
            if (PilhaVazia)
                throw new Exception("Pilha vazia");

            return ultimo.Valor;
        }

        public No RetornaTopo()
        {
            return ultimo;
        }

        public bool PilhaVazia { get { return ultimo == null; } }

        /// <summary>
        /// Topo da pilha
        /// </summary>
        private No ultimo; // = null;
    }
}
