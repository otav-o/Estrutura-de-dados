using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosOrdenacao
{
    public static class OrdenacaoPorTroca
    {
        // não finalizado!!
        public static void Quicksort(double[] vetor)
        {
            int indiceMaior = 1;
            int indiceMenor = vetor.Length - 1;
            int pivo = 0;
            do
            {
                while (vetor[indiceMaior] <= vetor[pivo])
                    indiceMaior++; // procura um elemento maior que o pivô
                while (vetor[indiceMenor] > vetor[pivo])
                    indiceMenor--;
                if (indiceMaior < indiceMenor)
                    InverterPosicoes(vetor, indiceMaior, indiceMenor);

            } while (vetor[indiceMaior] <= vetor[pivo]);
            InverterPosicoes(vetor, indiceMenor, pivo);
        } // não finalizado!!

        private static void InverterPosicoes(double[] vetor, int i, int j)
        {
            double aux = vetor[i];
            vetor[i] = vetor[j];
            vetor[j] = aux;
        }

        // escolher um elemento como pivô. Particionar o vetor em elementos menores ou iguais ao pivô e elementos maiores que o pivô
        // chamar novamente o método para cada um dos subvetores: chamada recursiva para cada um deles.
        // quando o índice menor passa pelo maior, o pivô é trocado para sua posução correta
        // profundidade da arvore de recursão: Ordem de log2n. 
        // Tempo de execução no melhor caso: nlog2n (melhor que n²)
        // tempo no pior caso: n²
        // pior caso: elementos ordenados e primeiro elemento como pivô
        // evitar o pior caso: escolher o valor médio entre 3 elementos do vetor (primeiro, do meio e 

        // O pivô estará na posição definitiva na primeira chamada?
        // Itens à esquerda são menores que o pivô. Maiores à direita. 
    }
}
