using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() : base() {}

        public SaldoInsuficienteException(string message) : base(message) {
        }
    }

    public class LimiteExcedidoException : Exception
    {
        public LimiteExcedidoException() : base("Limite excedido")
        {

        }

        public LimiteExcedidoException(decimal limite): base($"Limite excedido por: {limite}")
        {

        }
    }
}
