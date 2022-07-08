using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_2.Exceptions
{
    public class OpcaoNaoExistenteException : Exception
    {
        private const string Mensagem = "A opção selecionada é inválida\n";

        public OpcaoNaoExistenteException() : base (Mensagem)
        {

        }
    }
}
