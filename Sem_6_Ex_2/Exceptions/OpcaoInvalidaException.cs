using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_2.Exceptions
{
    internal class OpcaoInvalidaException : Exception
    {
        private const string Mensagem = "A opção selecionada é inválida\n";

        public OpcaoInvalidaException() : base (Mensagem)
        {

        }
    }
}
