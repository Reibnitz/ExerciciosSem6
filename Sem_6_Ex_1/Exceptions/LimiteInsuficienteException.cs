using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_1.Exceptions
{
    public class LimiteInsuficienteException : Exception
    {
        private const string Mensagem = "A conta {0} possui limite de saque insuficiente para realizar esta operação";

        public LimiteInsuficienteException(int numeroConta) : base(string.Format(Mensagem, numeroConta))
        {

        }
    }
}
