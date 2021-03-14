using System;
using System.Collections.Generic;
using System.Text;

namespace Fatorial
{
    class IteracaoPorRecorrencia
    {
        public static void Executar()
        {
            IteracaoInicial();
            Passo1();
            ImprimeAte5(1);

        }

        private static void ImprimeAte5(int i)
        {
            // passo2: crie uma função; substitua while por if e a atualização da variável por uma chamada recursiva

            if (i <= 5)
            {
                Console.WriteLine(i);
                ImprimeAte5(i + 1);
            }
        }

        private static void Passo1()
        {
            // passo1: substitua for por while
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        private static void IteracaoInicial()
        {
            // código inicial da iteração que se pretende transformar em recorrência
            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        }
    }
