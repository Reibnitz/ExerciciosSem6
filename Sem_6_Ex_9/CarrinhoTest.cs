using Sem_6_Ex_4.Interfaces;
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
    public class CarrinhoTest
    {
        private Produto _produto = new Produto(nome: "produto1", estoque: 10, valor: 5.5);

        [Fact]
        public void RemoverProduto_DeveriaRemoverProdutoExistente()
        {
            Carrinho carrinho = new()
            {
                Produtos = new List<IProduto>() {_produto},
                Quantidade = new List<int>() {10}
            };

            int esperado = 0;

            carrinho.RemoverProduto(_produto);

            int obtido = carrinho.Produtos.Count();

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void RemoverProduto_NaoDeveriaRemoverProdutoInexistente()
        {
            Carrinho carrinho = new();

            Assert.Throws<ProdutoInvalidoException>(
                () => carrinho.RemoverProduto(_produto)    
            );
        }

        [Fact]
        public void Listar_NaoDeveriaListarCarrinhoVazio()
        {
            Carrinho carrinho = new();

            Assert.Throws<CarrinhoVazioException>(
                () => carrinho.Listar()
            );
        }
    }
}
