namespace Sem_6_Ex_4.Interfaces
{
    public interface IProduto
    {
        int Estoque { get; set; }
        string Nome { get; set; }
        double Valor { get; set; }

        void RetirarEstoque(int quantidade);
    }
}