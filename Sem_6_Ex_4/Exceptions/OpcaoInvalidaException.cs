using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_4.Exceptions
{
    public class OpcaoInvalidaException : Exception
    {
        private const string Mensagem = "ERRO - Opção inválida";

        public OpcaoInvalidaException() : base(Mensagem)
        {
        }
    }
}
