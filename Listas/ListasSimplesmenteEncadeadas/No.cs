using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplesmenteEncadeadas
{
    class No
    {
        public int Valor
        {
            get { return valor;  }
            set { valor = value; }
        }

        /// <summary>
        /// Referência para o próximo nó
        /// </summary>
        public No Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

        private int valor;
        private No proximo = null;
    }
}
