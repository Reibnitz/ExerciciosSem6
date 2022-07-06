using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6.Exceptions
{
    internal class ValorInvalidoException : Exception
    {
        private const string Mensagem = "Só é possível realizar operações com valores maiores que zero";

        public ValorInvalidoException() : base(Mensagem)
        {

        }
    }
}
