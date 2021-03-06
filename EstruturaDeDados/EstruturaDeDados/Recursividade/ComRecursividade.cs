using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDeDados.Recursividade
{
    class ComRecursividade
    {
        public void OrdenarVetor(int[] A)
        {
            int i, j, k, t;
            for (i = 0; i < (A.Length - 1); i++)
            {
                j = i;
                k = (i + 1);
                while (k < A.Length) // etapa 1: transformar o for em while
                {
                    if (A[k] < A[i])
                        j = k;
                    k++;
                }
                t = A[i];
                A[i] = A[j];
                A[j] = t;
            }
        }
    }
}
