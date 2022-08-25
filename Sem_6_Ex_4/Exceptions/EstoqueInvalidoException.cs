using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_4.Exceptions
{
    public class EstoqueInvalidoException : Exception
    {
        private const string Mensagem = "ERRO - Estoque deve ser positivo";

        public EstoqueInvalidoException() : base(Mensagem)
        {
        }
    }
}
