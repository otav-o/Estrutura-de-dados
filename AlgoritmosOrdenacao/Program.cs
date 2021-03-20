using System;

namespace AlgoritmosOrdenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[] { 40, 20, 7, 80, 60, 50, 10, 30, 100 };

            // OrdenacaoPorTrocas.BubbleSort(vetor);
            // OrdenacaoPorInsercao.InsercaoDireta(vetor);

            OrdenacaoPorSelecao.OrdenarCrescente(vetor);

            ImprimirVetor(vetor);
        }

        private static void ImprimirVetor(double[] vetor)
        {
            foreach (var item in vetor)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
