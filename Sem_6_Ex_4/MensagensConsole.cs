using Sem_6_Ex_4.Exceptions;
using Sem_6_Ex_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_4
{
    public class MensagensConsole
    {
        public static EOpcao ListarOpcoes()
        {
            Console.WriteLine("\n1- Listar produtos disponíveis");
            Console.WriteLine("2- Listar produtos no carrinho de compras");
            Console.WriteLine("3- Adicionar produto ao carrinho de compras");
            Console.WriteLine("4- Remover produto do carrinho de compras");
            Console.Write("\nEscolha uma opção: ");

            bool escolha = int.TryParse(Console.ReadLine(), out int opcaoEscolhida);
            if (!escolha || opcaoEscolhida > 4 || opcaoEscolhida < 1)
                throw new OpcaoInvalidaException();

            return (EOpcao)opcaoEscolhida;
        }

        internal static void ListarProdutos(List<IProduto> listaEstoque)
        {
            Console.WriteLine("\n---- Lista de produtos -----");
            Console.WriteLine("Código - Preço - Produto");

            int codigo = 1;
            foreach(var l in listaEstoque)
            {
                Console.WriteLine($"{codigo} - R$ {l.Valor} - {l.Nome}");
                codigo++;
            }
        }

        internal static int EscolherQuantidade()
        {
            Console.Write("\nDigite a quantidade desejada: ");

            bool escolha = int.TryParse(Console.ReadLine(), out int opcaoEscolhida);
            if (!escolha)
                throw new OpcaoInvalidaException();

            return opcaoEscolhida;
        }

        internal static IProduto EscolherProduto(List<IProduto> lista)
        {
            Console.Write("\nDigite o código do produto: ");

            bool escolha = int.TryParse(Console.ReadLine(), out int opcaoEscolhida);
            if (!escolha)
                throw new OpcaoInvalidaException();
            if (opcaoEscolhida > lista.Count)
                throw new ProdutoInvalidoException();

            return lista[opcaoEscolhida - 1];
        }

        internal static void ListarCarrinho(ICarrinho carrinho)
        {
            if (carrinho.Produtos.Count == 0)
                throw new CarrinhoVazioException();

            Console.WriteLine("\n---- Carrinho de compras -----");
            string mensagem = carrinho.Listar();
            Console.WriteLine(mensagem);
        }
    }
}