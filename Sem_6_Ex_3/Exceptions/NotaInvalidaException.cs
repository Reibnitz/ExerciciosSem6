using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_3.Exceptions
{
    public class NotaInvalidaException : Exception
    {
        private const string MensagemErro = "ERRO - A nota \"{0}\" é inválida. Notas devem possuir valor de 0 a 10";

        public NotaInvalidaException(double nota) : base (string.Format(MensagemErro, nota))
        {

        }
    }
}
