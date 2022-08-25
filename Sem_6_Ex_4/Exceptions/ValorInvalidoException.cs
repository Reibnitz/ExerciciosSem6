using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_4.Exceptions
{
    public class ValorInvalidoException : Exception
    {
        private const string Mensagem = "ERRO - Valor deve ser positivo";

        public ValorInvalidoException() : base(Mensagem)
        {

        }
    }
}
