using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_1.Exceptions
{
    public class ValorInvalidoException : Exception
    {
        private const string Mensagem = "Só é possível realizar operações com valores maiores que zero";

        public ValorInvalidoException() : base(Mensagem)
        {

        }
    }
}
