using System;

namespace Pilhas
{
    class Program
    {
        static void Main(string[] args)
        {
            var pilha = new Pilha();

            pilha.AdicionarNoInicio(10);
            Imprimir(pilha);
        }

        private static void Imprimir(Pilha pilha)
        {
            var noAtual = pilha.RetornaTopo();

            

        }
    }
}
