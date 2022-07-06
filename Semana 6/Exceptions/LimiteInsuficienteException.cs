using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6.Exceptions
{
    internal class LimiteInsuficienteException : Exception
    {
        private const string Mensagem = "A conta {0} possui limite de saque insuficiente para realizar esta operação";

        public LimiteInsuficienteException(int numeroConta) : base(string.Format(Mensagem, numeroConta))
        {

        }
    }
}
