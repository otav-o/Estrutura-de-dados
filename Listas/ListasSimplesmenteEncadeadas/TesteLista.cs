using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplesmenteEncadeadas
{
    class TesteLista 
    {
        public void Testar()
        {
            try
            {
                var lista = new ListaEncadeada();
                Imprimir(lista);
                lista.AdicionarNoFinal(10);

                // lista.Primeiro.Valor = 6869; estragaria a lista

                Imprimir(lista);
                lista.AdicionarNoFinal(20);
                Imprimir(lista);
                lista.AdicionarNoInicio(0);
                Imprimir(lista);


                lista.RemoverNoInicio();
                Imprimir(lista);
                lista.RemoverNoInicio();
                Imprimir(lista);
                lista.RemoverNoInicio();
                Imprimir(lista);
                lista.RemoverNoInicio();
                Imprimir(lista);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro:\n{ex.Message}");
            }

            Console.ReadKey();
        }

        public static void Imprimir(ListaEncadeada lista)
        {
            Console.Write("Lista encadeada: ");
            No atual = lista.Primeiro;

            while (atual != null)
            {
                Console.Write($"{atual.Valor}");
                atual = atual.Proximo;
            }

            Console.WriteLine();
        }
    }
}
