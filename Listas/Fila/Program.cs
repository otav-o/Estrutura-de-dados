using System;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Fila<int>();

            f.AdicionarAoFinal(new No<int>(1));
            Imprimir(f);
            f.AdicionarAoFinal(new No<int>(2));
            Imprimir(f);
            f.AdicionarAoFinal(new No<int>(3));
            Imprimir(f);
            f.AdicionarAoFinal(new No<int>(4));
            Imprimir(f);
            f.AdicionarAoFinal(new No<int>(5));
            Imprimir(f);
            f.AdicionarAoFinal(new No<int>(6));
            f.AdicionarAoFinal(new No<int>(5));
            f.AdicionarAoFinal(new No<int>(0));
            Imprimir(f);


            Console.WriteLine(f.Primeiro.Valor);


        }

        private static void Imprimir<T> (Fila<T> fila)
        {
            fila.ParaCada(Imprimir<T>()); // ERROR
            Console.WriteLine();
        }
    }
}
1,2,3
    3,2,1

    3
    2
1
 
    1
    2
    3