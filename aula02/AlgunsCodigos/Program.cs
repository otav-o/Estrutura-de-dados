using System;

namespace AlgunsCodigos
{
    class Program
    {
        static void Main(string[] args)
        {
            var boletos = new Boleto[]
            {
                new Boleto { DataVencimento = new DateTime(2021, 3, 10), Valor = 120 },
                new Boleto { DataVencimento = new DateTime(2021, 4, 10), Valor = 115 },
                new Boleto { DataVencimento = new DateTime(2021, 5, 10), Valor = 110 }
            };

            for (int i = 0; i < boletos.Length; i++)
            {
                WriteLine("{0} - {1}", boletos[i].DataVencimento, boletos[i].Valor);
            }
        }

        static void WriteLine(string formato, object data, object valor)
        {
            string novaString = formato.Replace("{0}", data.ToString());
            novaString = novaString.Replace("{1}", valor.ToString());
            Console.WriteLine(novaString);
        }
        // todo objeto em C# herda de Object, e este tem um método ToString()
    }
}
