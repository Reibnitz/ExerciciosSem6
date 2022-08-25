using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_3.Exceptions
{
    internal class OpcaoInvalidaException : Exception
    {
        private const string MensagemErro = "A opção selecionada é inválida";

        public OpcaoInvalidaException() : base (MensagemErro)
        {

        }

        public OpcaoInvalidaException(string mensagem) : base(mensagem)
        {

        }
    }
}
