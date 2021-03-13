using System;
using System.Collections.Generic;
using System.Text;

namespace Fatorial
{
    class FatorialSemReferencia
    {
        public static void Executar()
        {
            Console.WriteLine("3! sem usar passagem por referência: " + Fatorial(3));
        }

        static int Fatorial(int numero)
        {
            int resultado = 1;

            return Fatorial(numero, resultado); // não passa uma cópia do valor, e sim o espaço de memória
        }

        static int Fatorial(int numero, int resultado)
        {
            if (numero > 1)
                return Fatorial(numero - 1, numero * resultado); // vai devolvendo o resultado final para as chamadas anteriores

            return resultado;
        }
    }
}
