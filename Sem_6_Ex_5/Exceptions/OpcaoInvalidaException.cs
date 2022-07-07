using System.Runtime.Serialization;

namespace Sem_6_Ex_5
{
    internal class OpcaoInvalidaException : Exception
    {
        private const string Mensagem = "ERRO: O usuário inseriu um dado inválido\n";

        public OpcaoInvalidaException() : base(Mensagem)
        {
        }
    }
}