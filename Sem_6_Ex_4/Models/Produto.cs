namespace Sem_6_Ex_4.Models
{
    public class Produto : IProduto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Estoque { get; set; }

        public Produto(string nome, double valor, int estoque)
        {
            Nome = nome;
            Valor = valor;
            Estoque = estoque;
        }

        public void RetirarEstoque(int quantidade)
        {
            if (quantidade > Estoque)
                throw new Exception();
            if (quantidade < 0)
                throw new Exception();

            Estoque -= quantidade;
        }
    }
}
