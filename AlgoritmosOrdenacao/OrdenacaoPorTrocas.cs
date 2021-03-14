using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosOrdenacao
{
    static class OrdenacaoPorTrocas
    {
        public static void BubbleSort(double[] vetor)
        {
            int fim = vetor.Length - 1; // inicialmente, o fim é a última posição do vetor.
            int pos; // indica a posição da última troca

            do
            {
                pos = -1;
                for (int i = 0; i < fim; i++)
                    if (vetor[i] > vetor[i + 1])
                    {
                        InverterPosicoes(vetor, i, i + 1);
                        pos = i;
                    }
                fim = pos; // só vai pesquisar até a última posição trocada
            } while (pos > 0);
        }

        public static void BubbleSort2(double[] vetor)
        {
            int fim = vetor.Length - 1, pos = -1;
            bool troca = true;
            while (troca)
            {
                troca = false;
                for (int i = 0; i < fim; i++)
                    if (vetor[i] > vetor[i + 1])
                    {
                        InverterPosicoes(vetor, i, i + 1);
                        troca = true;
                        pos = i;
                    }
                fim = pos;
            }
        }

        /// <summary>
        /// Recebe um vetor e troca os valores das posições passadas
        /// </summary>
        private static void InverterPosicoes(double[] vetor, int i, int j)
        {
            double aux = vetor[i];
            vetor[i] = vetor[j];
            vetor[j] = aux;
        }
    }
}
