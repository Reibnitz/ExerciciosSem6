using System.Runtime.Serialization;

namespace Sem_6_Ex_5
{
    internal class DiaSemMaisAtividadesException : Exception
    {
        private const string Mensagem = "ERRO: Não existem mais atividades marcadas para hoje\n";

        public DiaSemMaisAtividadesException() : base(Mensagem)
        {
        }
    }
}