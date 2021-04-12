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

        }

        static void TestarQuestao1()
        {
            Questao1.SomaMaioresQueZeroV1(new double[] { -1, 6.5, -4, -9, 8, 0, -1 });
            Questao1.SomaMaioresQueZeroV2(new double[] { -1, 6.5, -4, -9, 8, 0, -1 });
            var soma = Questao1.SomaMaioresQueZeroV3(new double[] { -1, 6.5, -4, -9, 8, 0, -1 });

            Console.WriteLine("A soma dos positivos é [recursividade] " + soma);
        }
    }
}
