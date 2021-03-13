using System;
using System.Collections.Generic;
using System.Text;

namespace Fatorial
{
    class FatorialPassagemPorRef
    {
        public static void Executar()
        {
            Console.WriteLine("5! usando passagem por referência: " + Fatorial(5));
        }

        static int Fatorial(int numero)
        {
            int resultado = 1;

            Fatorial(numero, ref resultado); // não passa uma cópia do valor, e sim o espaço de memória

            return resultado;
        }

        static void Fatorial(int numero, ref int resultado)
        {
            if (numero > 1)
            {
                resultado *= numero;
                Fatorial(numero - 1, ref resultado);
            }
        }
    }
}
