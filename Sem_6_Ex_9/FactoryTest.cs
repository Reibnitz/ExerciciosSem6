using Sem_6_Ex_4;
using Sem_6_Ex_4.Exceptions;
using Sem_6_Ex_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sem_6_Ex_9
{
    public class FactoryTest
    {
        [Fact]
        public void CriarProduto_DeveriaCriarComValorPositivo()
        {
            double esperado = 5.5;

            IProduto produto = Factory.CriarProduto(nome: "nome produto", valor: 5.5, estoque: 100);
            double obtido = produto.Valor;

            Assert.Equal(esperado, obtido);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CriarProduto_NaoDeveriaCriarComValorZeroOuNegativo(double valor)
        {
            Assert.Throws<ValorInvalidoException>(
                () => Factory.CriarProduto(nome: "nome produto", valor: valor, estoque: 100)
            );
        }

        [Fact]
        public void CriarProduto_DeveriaCriarComEstoquePositivo()
        {
            double esperado = 100;

            IProduto produto = Factory.CriarProduto(nome: "nome produto", valor: 5.5, estoque: 100);
            double obtido = produto.Estoque;

            Assert.Equal(esperado, obtido);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CriarProduto_NaoDeveriaCriarComEstoqueZeroOuNegativo(int estoque)
        {
            Assert.Throws<EstoqueInvalidoException>(
                () => Factory.CriarProduto(nome: "nome produto", valor: 5.5, estoque: estoque)
            );
        }
    }
}
