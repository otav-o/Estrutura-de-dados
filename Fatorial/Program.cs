using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //FatorialPassagemPorRef.Executar();
            //EntenderRef.Executar();
            //FatorialSemReferencia.Executar();

            //Console.WriteLine(Fatorial(5));

            IteracaoPorRecorrencia.Executar();
        }

        static int Fatorial(int numero)
        {
            if (numero == 0)
                return 1;

            return numero * Fatorial(numero - 1); // faz a conta pelos retornos das funções
        }
    }
}
