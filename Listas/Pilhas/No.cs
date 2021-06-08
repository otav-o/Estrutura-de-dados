using System;
using System.Collections.Generic;
using System.Text;

namespace Pilhas
{
    class No
    {
        public No (int valor)
        {
            Valor = valor;
        }

        public No Proximo { get; set; }
        public No Anterior { get; set; }
        public int Valor { get; set; }
    }
}
