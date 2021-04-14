using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho2
{
    /*
     * QUESTÃO 03 (2 pontos): Faça um procedimento que receba um vetor de números inteiros e reorganize os seus elementos em ordem crescente de valores utilizando para isso o método da seleção. No método principal (Main), crie o vetor {2, 5, 0, 9, 1, 4} e passe-o por parâmetro para o procedimento criado.
    */

    class Questao3
    {
        public static void OrdenarCrescente(int[] vetor)
        {
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                int indiceMenor = i; // começa sendo o primeiro do vetor não ordenado
                // localiza o índice do menor elemento da parte não ordenada do vetor
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[indiceMenor])
                        indiceMenor = j;
                }
                if (i != indiceMenor)
                    InverterPosicoes(vetor, i, indiceMenor); // troca o item i pelo de índice menor (que já vai estar na posição correta)
            }
        }

        /*
         * [][_,_,_,_,_,_]
         * [_][_,_,_,_,_] -> coloca o menor valor de todo o vetor na primeira posição
         * [_,_][_,_,_,_] -> coloca o menor valor do desordenado (e segundo menor de todo o vetor) na segunda posição (que já é a correta)
         * [_,_,_][_,_,_] -> etc.
         * [_,_,_,_,_][_] -> fim do for
         */

        static void InverterPosicoes(int[] vet, int i, int j)
        {
            var aux = vet[i];
            vet[i] = vet[j];
            vet[j] = aux;
        }

        public static void OrdenarCrescenteV2(int[] vetor)
        {
            int i = 0;
            while (i < vetor.Length - 1)
            {
                int indiceMenor = i;

                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[indiceMenor])
                        indiceMenor = j;
                }
                if (i != indiceMenor)
                    InverterPosicoes(vetor, i, indiceMenor);

                i++;
            }
        }
        // RESPOSTA FINAL
        public static void OrdenarCrescenteV3(int[] vetor, int i = 0)
        {
            if (i < vetor.Length - 1)
            {
                int indiceMenor = i;

                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[indiceMenor])
                        indiceMenor = j;
                }
                if (i != indiceMenor)
                    InverterPosicoes(vetor, i, indiceMenor);

                OrdenarCrescenteV3(vetor, ++i);
            }
        }

        public static void OrdenarCrescenteV4(int[] vetor, int i = 0)
        {
            if (i < vetor.Length - 1)
            {
                int indiceMenor = i;

                int j = i + 1;
                while (j < vetor.Length)
                {
                    if (vetor[j] < vetor[indiceMenor])
                        indiceMenor = j;
                    j++;
                }
                if (i != indiceMenor)
                    InverterPosicoes(vetor, i, indiceMenor);

                OrdenarCrescenteV4(vetor, ++i);
            }
        }

        // Acredito que para ter recursividade em loops aninhados precise de outra função
        // (Não rolou)
        // https://stackoverflow.com/questions/44397474/convert-nested-loop-to-recursion

        /*
            public static void OrdenarCrescenteV5(int[] vetor, int i = 0, int j = 0)
            {
                if (i < vetor.Length - 1)
                {
                    int indiceMenor = i;

                    if (j < vetor.Length)
                    {
                        if (vetor[j] < vetor[indiceMenor])
                            indiceMenor = j;
                        OrdenarCrescenteV5(vetor, 0, i + 1);
                    }
                    if (i != indiceMenor)
                        InverterPosicoes(vetor, i, indiceMenor);

                    OrdenarCrescenteV5(vetor, ++i);
                }
            }
        */
    }
}
