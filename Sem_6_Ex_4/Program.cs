using Sem_6_Ex_4;
using Sem_6_Ex_4.Interfaces;

List<IProduto> listaEstoque = new List<IProduto>()
{
    Factory.CriarProduto("Arroz", 3.50, 50),
    Factory.CriarProduto("Feijão", 5.90, 50),
    Factory.CriarProduto("Sal", 2.50, 100),
    Factory.CriarProduto("Açúcar", 1.90, 75),
    Factory.CriarProduto("Café", 19.90, 30),
    Factory.CriarProduto("Macarrão", 6.50, 20),
    Factory.CriarProduto("Leite", 5.30, 50),
    Factory.CriarProduto("Manteiga", 12.00, 10),
};

ICarrinho carrinho = Factory.CriarCarrinho();