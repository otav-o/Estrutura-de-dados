using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplesmenteEncadeadas
{
    class ListaEncadeada
    {
        public void AdicionarNoInicio(int valor)
        {
            var novoNo = new No { Valor = valor };

            novoNo.Proximo = primeiro;
            primeiro = novoNo;
        }

        public void AdicionarNoFinal(int valor)
        {
            var novoNo = new No { Valor = valor };

            if (primeiro == null)
                primeiro = novoNo;
            else
            {
                var ultimo = primeiro;

                while (ultimo.Proximo != null)
                    ultimo = ultimo.Proximo;

                ultimo.Proximo = novoNo;
            }
        }

        public void RemoverNoInicio()
        {
            if (primeiro == null)
                throw new Exception("A lista está vazia");

            primeiro = primeiro.Proximo;
        }

        public void RemoverNoFinal()
        {
            if (primeiro == null)
                throw new Exception("A lista está vazia");
            else if (primeiro.Proximo == null)
                primeiro = null;
            else
            {
                var penultimo = primeiro;

                while (penultimo.Proximo.Proximo != null)
                    penultimo = penultimo.Proximo;

                penultimo.Proximo = null;
            }
        }

        public No Primeiro // fere o encapsulamento
        { 
            get { return primeiro; }
        } // próxima aula: uma solução melhor

        private No primeiro;
    }
}
