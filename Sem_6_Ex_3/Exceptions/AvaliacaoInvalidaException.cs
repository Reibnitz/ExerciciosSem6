using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_3.Exceptions
{
    public class AvaliacaoInvalidaException : Exception
    {
        private const string MensagemErro = "ERRO - Número de avaliação \"{0}\" inválido. Esta disciplina possui apenas {1} avaliações";

        public AvaliacaoInvalidaException(int avaliacaoDefinida, int avaliacaoMaxima)
            : base(string.Format(MensagemErro, avaliacaoDefinida, avaliacaoMaxima))
        {

        }
    }
}
