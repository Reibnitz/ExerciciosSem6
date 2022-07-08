using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_2.Exceptions
{
    public class CalculoInvalidoException : Exception
    {
        private const string Mensagem = "Não é possível dividir por zero\n";
        public CalculoInvalidoException() : base(Mensagem)
        {

        }
    }
}
