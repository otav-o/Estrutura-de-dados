using EstruturaDeDados.Recursividade;
using System;
using System.Collections;

namespace EstruturaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 55, 23, 12, 1, 5, 2, 3, 2, 85, 23, 0, 04 };
            var teste = new SemRecursividade();
            teste.OrdenarVetor(array);

            ImprimirColecao(array);

        }

        private static void ImprimirColecao(IEnumerable vetor)
        {
            foreach(var elemento in vetor)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
