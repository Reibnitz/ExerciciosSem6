using Sem_6_Ex_4.Exceptions;
using Sem_6_Ex_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sem_6_Ex_9
{
    public class ProdutoTest
    {
        private Produto _produto = new(nome: "nome", valor: 5.5, estoque: 5);

        [Fact]
        public void RetirarEstoque_DeveriaRetirarQuantidadeValida()
        {
            int esperado = 4;

            _produto.RetirarEstoque(1);
            int obtido = _produto.Estoque;

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void RetirarEstoque_DeveriaRetirarQuantidadeMaiorQueEstoque()
        {
            Assert.Throws<EstoqueInvalidoException>(
                () => _produto.RetirarEstoque(6)    
            );
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void RetirarEstoque_DeveriaRetirarQuantidadeNegativaOuZero(int quantidade)
        {
            Assert.Throws<ValorInvalidoException>(
                () => _produto.RetirarEstoque(quantidade)
            );
        }
    }
}
