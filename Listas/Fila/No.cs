using System;
using System.Collections.Generic;
using System.Text;

namespace Fila
{
    class No<T>
    {
        public No (T valor)
        {
            Valor = valor;
        }

        public No<T> Proximo { get; set; }
        public T Valor { get; set; }
    }
}
