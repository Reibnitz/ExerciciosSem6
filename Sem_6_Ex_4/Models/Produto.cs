using Sem_6_Ex_4.Exceptions;
using Sem_6_Ex_4.Interfaces;

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
                throw new EstoqueInvalidoException("ERRO - Quantidade excede o estoque");
            if (quantidade <= 0)
                throw new ValorInvalidoException("ERRO - Quantidade deve ser maior que zero");

            Estoque -= quantidade;
        }
    }
}
