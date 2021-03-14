using System;
using System.Collections.Generic;
using System.Text;

namespace Fatorial
{
    class IteracaoPorRecorrencia2
    {
        public static void Executar()
        {
            ImprimirDeAte(1, 5);
            ImprimirDe1Ate(5);
        }

        static void ImprimirDe1Ate(int numero)
        {
            if (numero > 0)
            {
                ImprimirDe1Ate(numero - 1);
                Console.WriteLine(numero);
            }
        }

        static void ImprimirDeAte(int de, int ate) 
        {
            if (de <= ate) // quando for falso, não vai chamar a si próprio de novo
            {
                Console.WriteLine(de);
                ImprimirDeAte(de + 1, ate);
            }
        }
    }
}
