using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6.Exceptions
{
    internal class SaldoInsuficienteException : Exception
    {
        private const string Mensagem = "A conta {0} possui saldo insuficiente para realizar esta operação";

        public SaldoInsuficienteException(int numeroConta) : base(string.Format(Mensagem, numeroConta))
        {

        }
    }
}
