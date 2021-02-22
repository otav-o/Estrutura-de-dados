using AlgunsCodigos;
using System;

namespace TesteDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto meuBoleto = new Boleto();
            meuBoleto.DataVencimento = new DateTime(2021, 2, 21);
            meuBoleto.Valor = 150;

            Console.WriteLine($"Data: {meuBoleto.DataVencimento}, valor: {meuBoleto.Valor}");
        }
    }
}
