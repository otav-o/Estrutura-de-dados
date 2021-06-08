using System;
using System.Collections.Generic;
using System.Text;

namespace IgualdadeListasEncadeadas
{
    class No
    {
        public No (double valor)
        {
            Valor = valor;
        }
        public No Proximo { get; set; }
        public double Valor { get; set; }

        public bool IsEqual(No no)
        {
            if (no.Valor == this.Valor)
                return true;
            return false;
        }
    }
}
