using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplesmenteEncadeadas
{
    class No<T>
    {
        public T Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public No<T> Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

        public No<T> Anterior { get; set; }

        private T valor;
        private No<T> proximo;
    }
}

