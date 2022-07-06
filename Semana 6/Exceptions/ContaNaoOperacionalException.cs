using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6.Exceptions
{
    internal class ContaNaoOperacionalException : Exception
    {
        private const string Mensagem = "A conta {0} não está em estado operacional";

        public ContaNaoOperacionalException(int numeroConta) : base(string.Format(Mensagem, numeroConta))
        {

        }
    }
}
