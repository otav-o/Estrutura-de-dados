using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho2
{
    /*
     * QUESTÃO 02 (2 pontos): Faça uma função que receba um número inteiro por parâmetro e retorne a soma dos números primos entre 1 e o número recebido por parâmetro. A função não deve utilizar comandos de repetição, ou seja, deve ser uma função recursiva.
     */

    class Questao2
    {
        public static void SomaNumerosPrimosAte(int num)
        {
            int soma = 0;
            for (int i = 2; i < num; i++)
                if (ChecarSeEPrimoV3(i))
                    soma += i;
                      
            Console.WriteLine($"A soma dos primos até {num} é [iteração com for] {soma}");
        }

        public static void SomaNumerosPrimosAteV2(int num)
        {
            int soma = 0;

            int i = 2;
            while (i < num)
            {
                if (ChecarSeEPrimoV3(i))
                    soma += i;

                i++;
            }

            Console.WriteLine($"A soma dos primos até {num} é [iteração com while] {soma}");
        }

        // RESPOSTA FINAL JUNTO COM O MÉTODO SomaNumerosPrimosAteV3()
        public static int SomaNumerosPrimosAteV3(int num, int i = 2)
        {
            int soma = 0;

            if (i < num)
            {
                if (ChecarSeEPrimoV3(i))
                    soma += i;

                soma += SomaNumerosPrimosAteV3(num, ++i);
            }

            return soma;
        }


        static Boolean ChecarSeEPrimo(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }

        static bool ChecarSeEPrimoV2(int num)
        {
            int i = 2;
            while (i < num)
            {
                if (num % i == 0)
                    return false;
                i++;
            }
            return true;
        }

        // FUNÇÃO RECURSIVA PARA ACHAR NÚMERO PRIMO: OK
        static bool ChecarSeEPrimoV3(int num, int i = 2)
        {
            if (i < num)
            {
                if (num % i == 0)
                    return false;
                return ChecarSeEPrimoV3(num, ++i);
            }
            return true;
        }
    }
}
