using System.Runtime.Serialization;

namespace Sem_6_Ex_5
{
    public class DuracaoInvalidaException : Exception
    {
        private const string Mensagem = "ERRO: A duração {0} excede o limite de 4 horas";
        private const string MensagemPadrao = "ERRO: Duração inválida";

        public DuracaoInvalidaException(TimeSpan duracao) : base(string.Format(Mensagem, duracao))
        {
        }

        public DuracaoInvalidaException() : base (MensagemPadrao)
        {

        }
    }
}