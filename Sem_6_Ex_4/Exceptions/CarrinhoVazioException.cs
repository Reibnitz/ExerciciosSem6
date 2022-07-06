using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_4.Exceptions
{
    public class CarrinhoVazioException : Exception
    {
        private const string Mensagem = "ERRO - O carrinho não possui nenhum produto";

        public CarrinhoVazioException() : base(Mensagem)
        {
        }
    }
}
