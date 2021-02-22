using System;
using System.Collections.Generic;
using System.Text;

namespace AlgunsCodigos
{
    class Boleto
    {
        private DateTime data;
        private double valor;

        public DateTime Data { get => data; set => data = value; }
        // public DateTime Data { get { return data; } set { data = value; } }
        // operador lambda: executa uma expressão. Se for apenas uma variável, entende como retorno

        public double Valor { get => valor; set => valor = value; }
    }
}
