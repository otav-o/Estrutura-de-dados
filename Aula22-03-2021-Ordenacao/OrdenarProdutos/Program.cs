/*
 * Ordenar um vetor de produtos pelo preço do produto. Um produto possui um código (int), uma descrição e um preço.
 * Utilize os métodos da inserção e da seleção.
 */

using System;

namespace OrdenarProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            var prods = GerarVetorProdutos();
            OrdenarProdutosPorPrecoInsercao(prods);
            ImprimirProdutos(prods);
        }

        private static Produto[] GerarVetorProdutos()
        {
            return new Produto[]
            {
                new Produto {Preco = 15.3, Descricao="Água"},
                new Produto {Preco = 20.2, Descricao="Leite" },
                new Produto {Preco = 10.1, Descricao="Mouse"},
                new Produto {Preco = 23.1, Descricao="Arroz"}
            };
        }

        private static void ImprimirProdutos(Produto[] produtos)
        {
            foreach (var p in produtos) Console.WriteLine(p.Descricao + " " + p.Preco);
        }

        private static void OrdenarProdutosPorPrecoInsercao(Produto[] produtos)
        {
            for (int i = 1; i < produtos.Length; i++)
            {
                Produto checagem = produtos[i];
                int j = i - 1;
                
                while (j >= 0 && checagem.Preco < produtos[j].Preco)
                {
                    produtos[j + 1] = produtos[j];
                    j--;
                }
                produtos[j + 1] = checagem;
            }
        }

        private static void OrdenarProdutosInsercaoCamillo(Produto[] produtos)
        {
            int j;
            for (int i = 1; i < produtos.Length; i++)
            {
                var aux = produtos[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (produtos[j].Preco > aux.Preco)
                        produtos[j + 1] = produtos[j];
                    else
                        break;
                }
                produtos[j + 1] = aux;
            }
        }

        private static void OrdenarProdutosPorPrecoSelecao(Produto[] produtos)
        {

        }

        private static void TrocarPosicoes(Produto[] produtos, int i, int j)
        {
            var aux = produtos[i];
            produtos[i] = produtos[j];
            produtos[j] = aux;
        }
    }
}
