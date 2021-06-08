using System;

namespace Resposta
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista1 = new ListaEncadeada();
            var lista2 = new ListaEncadeada();

            lista1.AdicionarNoInicio(10);
            lista1.AdicionarNoFinal(20);
            lista1.AdicionarNoInicio(0);

            lista2.AdicionarNoFinal(50);
            lista2.AdicionarNoInicio(0);
            lista2.AdicionarNoInicio(10);

            Console.WriteLine($"As listas{(ListasIguais(lista1, lista2) ? " " : " não ")}são iguais");
        }

        static bool ListasIguais(ListaEncadeada lista1, ListaEncadeada lista2)
        {
            if (lista1 == null || lista2 == null)
                throw new Exception("Pelo menos uma das listas é nula");

            if (lista1.Tamanho != lista2.Tamanho)
                return false;

            var elemLista1 = lista1.Primeiro;
            var elemLista2 = lista2.Primeiro;

            while (elemLista1 != null)
            {
                if (elemLista1.Valor != elemLista2.Valor)
                    return false;

                elemLista1 = elemLista1.Proximo;
                elemLista2 = elemLista2.Proximo;
            }

            return true;
        }
    }
}
