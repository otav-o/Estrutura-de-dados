using System;

namespace ListasContiguas
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new ListaContigua();
            lista.Adicionar(3.5);
            lista.Adicionar(12.2);
            lista.Adicionar(5);

            try
            {
                lista[2] = 3;
                lista[5] = 3;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Imprimir(lista);           
        }

        static void Imprimir(ListaContigua lista)
        {
            for (int i = 0; i < lista.Tamanho; i++)
            {
                Console.WriteLine(lista.RetornarItem(i));
            }
        }
    }
}
