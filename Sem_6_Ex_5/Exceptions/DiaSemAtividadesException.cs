using System.Runtime.Serialization;

namespace Sem_6_Ex_5
{
    public class DiaSemAtividadesException : Exception
    {
        private const string Mensagem = "ERRO: Não existem compromissos marcados para o dia {0}\n";

        public DiaSemAtividadesException(DateOnly data) : base(string.Format(Mensagem, data))
        {
        }
    }
}