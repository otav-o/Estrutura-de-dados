using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDeDados.Recursividade
{
    class SemRecursividade
    {
        public void OrdenarVetor(int[] A)
        {
            int i, j, k, t;
            for (i = 0; i < (A.Length - 1); i++)
            {
                j = i;
                for (k = (i + 1); k < A.Length; k++)
                    if (A[k] < A[i])
                        j = k;
                t = A[i];
                A[i] = A[j];
                A[j] = t;
            }
        }
    }
}
