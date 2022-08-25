using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_5.Exceptions
{
    public class HorarioInvalidoException : Exception
    {
        private const string Mensagem = "ERRO: Horário inválido";

        public HorarioInvalidoException() : base(Mensagem)
        {
        }
    }
}
