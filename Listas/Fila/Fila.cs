using System;
using System.Collections.Generic;
using System.Text;

namespace Fila
{
    class Fila<T>
    {
        public Fila()
        {
            
        }

        public No<T> Primeiro { get; set; }
        public No<T> Ultimo { get; set; }

        public void AdicionarAoFinal(No<T> no)
        {
            if (Primeiro == null)
            {
                Primeiro = no;
                Ultimo = no;
            }
            else
            {
                Ultimo.Proximo = no;
                Ultimo = no;
            }
        }
        public void RemoverNoInicio()
        {
            if (FilaVazia)
                throw new Exception("A fila está vazia, não foi possível remover.");
            Primeiro.Proximo = Primeiro;
        }

        public bool FilaVazia { get => Primeiro == null; }

        public void ParaCada(Action<T> acao)
        {
            var noAtual = Primeiro;
            while (noAtual != null)
            {
                acao(noAtual.Valor);
                noAtual = noAtual.Proximo;
            }
        }
    }
}
