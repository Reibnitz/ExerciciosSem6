namespace Sem_6_Ex_4.Interfaces
{
    public interface ICarrinho
    {
        List<IProduto> Produtos { get; set; }
        List<int> Quantidade { get; set; }

        void AdicionarProduto(IProduto produto, int quantidade);
        string Listar();
        void RemoverProduto(IProduto produto);
    }
}