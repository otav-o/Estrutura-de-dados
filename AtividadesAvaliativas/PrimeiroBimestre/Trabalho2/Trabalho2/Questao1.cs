using System;

namespace Trabalho2
{
    /*
     * QUESTÃO 01 (2 pontos): Faça um procedimento que receba por parâmetro um vetor de números reais e imprima a soma dos elementos maiores que zero desse vetor. O procedimento não deve utilizar comandos de repetição, ou seja, deve ser um procedimento recursivo.
        Exemplo:
        - Para o vetor {-1, 6.5, -4, -9, 8, 0, -1}, o algoritmo deve imprimir: Soma dos positivos: 14,5
    */

    class Questao1
    {
        public static void SomaMaioresQueZeroV1(double [] vet)
        {
            double soma = 0;
            for (int i = 0; i < vet.Length; i++)
                if (vet[i] > 0)
                    soma += vet[i];

            Console.WriteLine("A soma dos positivos é [iteração com for] " + soma);
        }

        public static void SomaMaioresQueZeroV2(double[] vet)
        {
            double soma = 0;
            int i = 0;
            while (i < vet.Length)
            {
                if (vet[i] > 0)
                    soma += vet[i];
                i++;
            }

            Console.WriteLine("A soma dos positivos é [iteração com while] " + soma);
        }

        // RESPOSTA FINAL - QUESTÃO 1
        public static double SomaMaioresQueZeroV3(double[] vet, int i = 0)
        {
            double soma = 0;
          
            if (i < vet.Length)
            {
                if (vet[i] > 0)
                    soma += vet[i];
                soma += SomaMaioresQueZeroV3(vet, i + 1);
            }
            return soma;
        }
    }
}
