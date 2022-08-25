using Sem_6_Ex_4.Interfaces;

namespace Sem_6_Ex_4.Exceptions
{
    [Serializable]
    public class ProdutoInvalidoException : Exception
    {
        private const string Mensagem = "ERRO - O produto {0} não se encontra no carrinho";

        public ProdutoInvalidoException(IProduto produto) : base(string.Format(Mensagem, produto))
        {
        }

        public ProdutoInvalidoException() : base(string.Format(Mensagem, ""))
        {

        }
    }
}