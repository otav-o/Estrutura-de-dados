using System;
using System.Collections.Generic;
using System.Text;

namespace AlgunsCodigos
{
    public class Boleto
    {
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        // public DateTime Data { get { return data; } set { data = value; } }
        // operador lambda: executa uma expressão. Se for apenas uma variável, entende como retorno

        public double Valor { get => valor; set => valor = value; }

        public bool EstaVencido() => DateTime.Now.Date > DataVencimento.Date;

        private DateTime dataVencimento;
        private double valor;
    }
}
