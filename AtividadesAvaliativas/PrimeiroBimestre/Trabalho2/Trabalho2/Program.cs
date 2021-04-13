using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestarQuestao1();

            TestarQuestao2();

        }

        static void TestarQuestao1()
        {
            Questao1.SomaMaioresQueZeroV1(new double[] { -1, 6.5, -4, -9, 8, 0, -1 });
            Questao1.SomaMaioresQueZeroV2(new double[] { -1, 6.5, -4, -9, 8, 0, -1 });
            var soma = Questao1.SomaMaioresQueZeroV3(new double[] { -1, 6.5, -4, -9, 8, 0, -1 });

            Console.WriteLine("A soma dos positivos é [recursividade] " + soma);
        }

        static void TestarQuestao2()
        {
            var n = 10;

            Questao2.SomaNumerosPrimosAte(n);
            Questao2.SomaNumerosPrimosAteV2(n);
            var soma = Questao2.SomaNumerosPrimosAteV3(n);

            Console.WriteLine($"A soma dos primos até {n} é [recursividade] " + soma);
        }
    }
}
