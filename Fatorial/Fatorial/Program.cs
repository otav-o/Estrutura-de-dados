using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Procedimento(ref x);
            Console.WriteLine(x); // imprime 10
        }

        private static void Procedimento(ref int x)
        {
            x *= 2;
        }
    }
}
