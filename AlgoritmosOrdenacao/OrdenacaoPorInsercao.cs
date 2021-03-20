using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosOrdenacao
{
    public static class OrdenacaoPorInsercao
    {
        public static void InsercaoDireta (double[] vetor)
        {
            // A parte ordenada está entre 0 e i
            for (int i = 1; i < vetor.Length; i++)
            {
                double chave = vetor[i]; // valor a ser inserido na parte ordenada
                int j = i - 1;

                // transfere todos os valores para índices maiores até encontrar a posição do elemento
                while (j >= 0 && chave < vetor[j])
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }
                vetor[j + 1] = chave;
            }
        }

        /*
        public static void InsercaoDireta(double[] vetor)
        {
            int fim = 1;
            double chave;
            for (int i = 0; i < vetor.Length; i++)
            {
                chave = vetor[i];
                for (int j = fim; j > 0; j--)
                {
                    if (vetor[j - 1] > chave)
                        vetor[j + 1] = vetor[j];
                    else
                    {
                        vetor[j] = chave;
                        fim = j;
                    }
                }
            } // minha tentativa. Não funciona!
        
        }
        */
    }
}
