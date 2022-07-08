using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_2.Exceptions
{
    public class EntradaInvalidaException : Exception
    {
        private const string Mensagem = "Valor inválido\n";

        public EntradaInvalidaException() : base(Mensagem)
        {

        }
    }
}
