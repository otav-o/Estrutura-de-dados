using System;
using System.Collections.Generic;
using System.Text;

namespace IgualdadeListasEncadeadas
{
    class ListaEncadeada
    {
        public No Primeiro { get; set; }
        public No Ultimo { get; set; }

        public void AdicionarNoFinal(double valor)
        {
            var novoNo = new No (valor);
            Ultimo.Proximo = novoNo;
            Ultimo = novoNo;
        }

        public void AdicionarNoInicio(double valor)
        {
            var novoNo = new No(valor);
            novoNo.Proximo = Primeiro;
            Primeiro = novoNo;
        }

        public bool IsEqual(ListaEncadeada outraLista)
        {
            var no = Primeiro;
            var outroNo = outraLista.Primeiro;

            while (no == outroNo)
            {

            }
        }
    }
}
