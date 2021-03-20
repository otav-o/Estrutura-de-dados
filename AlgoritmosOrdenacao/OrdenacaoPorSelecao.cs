using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosOrdenacao
{
    public static class OrdenacaoPorSelecao
    {
        public static void OrdenarCrescente(double[] vetor)
        {
            for (int i = 0; i < vetor.Length-1; i++)
            {
                int indiceMenor = i;
                // localiza o índice menor do menor elemento na parte não ordenada do vetor
                for (int j = i+1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[indiceMenor])
                        indiceMenor = j;
                }
                if (i != indiceMenor)
                    InverterPosicoes(vetor, i, indiceMenor); // troca o item i pelo de índice menor
            }
        }


        private static void InverterPosicoes(double[] vetor, int i, int j)
        {
            double aux = vetor[i];
            vetor[i] = vetor[j];
            vetor[j] = aux;
        }


        /*
        public static void OrdenarCrescente (double[] vetor)
        {
            int indiceMenor = 0, indiceFim = 0;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                // achar o menor valor do segmento não ordenado
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[indiceMenor])
                        indiceMenor = j;
                }
                InverterPosicoes(vetor, i, indiceMenor);
                indiceFim++;
            }
        }*/
    }
}
