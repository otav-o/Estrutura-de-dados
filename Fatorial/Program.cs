using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fatorial(5));
        }
        // Fatorial com passagem por referência
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
