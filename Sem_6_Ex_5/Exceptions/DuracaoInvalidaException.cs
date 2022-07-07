using System.Runtime.Serialization;

namespace Sem_6_Ex_5
{
    internal class DuracaoInvalidaException : Exception
    {
        private const string Mensagem = "ERRO: A duração {0} excede o limite de 4 horas\n";

        public DuracaoInvalidaException(TimeSpan duracao) : base(string.Format(Mensagem, duracao))
        {
        }
    }
}