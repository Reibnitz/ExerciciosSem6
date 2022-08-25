using Sem_6_Ex_4.Exceptions;
using Sem_6_Ex_4.Interfaces;
using Sem_6_Ex_4.Models;

namespace Sem_6_Ex_4
{
    public class Factory
    {
        public static IProduto CriarProduto(string nome, double valor, int estoque)
        {
            if (valor <= 0) throw new ValorInvalidoException("ERRO - Valor deve ser positivo");
            if (estoque <= 0) throw new EstoqueInvalidoException("ERRO - Estoque deve ser positivo");

            return new Produto(nome, valor, estoque);
        }

        public static ICarrinho CriarCarrinho()
        {
            return new Carrinho();
        }
    }
}
