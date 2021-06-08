using System;

namespace MultiplicacaoRecursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Multiplicação sem recursividade: {Multiplicar(3, 2)}");
            Console.WriteLine($"Multiplicação sem recursividade: {MultiplicarParte1(3, 2)}");
            Console.WriteLine($"Multiplicação com recursividade: {MultiplicarRecursivamente(3, 2)}");
        }

        static double Multiplicar(int a, int b) // iteração
        {
            int resultado = 0;
            for (int i = 0; i < b; i++)
                resultado += a;
            return resultado;
        }

        static double MultiplicarParte1(int a, int b) // Passo 1: substituir for por while
        {
            int resultado = 0;
            int i = 0;
            while (i < b)
            {
                resultado += a;
                i++;
            }
            return resultado;
        }

        static int MultiplicarRecursivamente(int a, int b) // Passo 2: substituir while por if e a atualização do contador pela chamada com o novo valor
        {
            int resultado = 0;
            int i = 0; // está errado!
            if (i < b)
            {
                resultado += a;
                resultado += MultiplicarRecursivamente(a, b-1);
            }
            return resultado;
        }
    }
}
