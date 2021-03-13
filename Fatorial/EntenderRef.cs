using System;
using System.Collections.Generic;
using System.Text;

namespace Fatorial
{
    class EntenderRef
    {
        public static void Executar()
        {
            int x = 10;
            ProcedimentoSemRef(x);
            Console.WriteLine("Procedimento sem o ref: " + x); // imprime 10

            int y = 10;
            ProcedimentoComRef(ref y);
            Console.WriteLine("Procedimento com o ref: " + y); // imprime 20

            int z = 10;
            ProcedimentoComOut(out z);
            Console.WriteLine("Procedimento com out: " + z);


            if (int.TryParse("20", out int idade))
                Console.WriteLine("Idade informada (intTryParse out idade): " + idade);
            else
                Console.WriteLine("Idade inválida!");
        }

        private static void ProcedimentoComOut(out int x)
        {
            // o código da subrotina é obrigado a fornecer um valor para a variável out
            // ref: pode alterar; out: é obrigado a alterar.
            // out: não consegue ler o valor antes de atribuir
            x = 2000;
        }

        private static void ProcedimentoSemRef(int x) // passagem por valor
        {
            x *= 2;
        }

        private static void ProcedimentoComRef(ref int x) // passagem por referência
        {
            x *= 2;
        }

        // importante: somente variáveis podem ser passadas por referência (não servem expressões)
    }
}
