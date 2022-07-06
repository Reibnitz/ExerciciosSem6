﻿namespace Sem_6_Ex_4.Models
{
    public class Carrinho : ICarrinho
    {
        public List<IProduto> Produtos { get; set; } = new List<IProduto>();
        public List<int> Quantidade { get; set; } = new List<int>();

        public void AdicionarProduto(IProduto produto, int quantidade)
        {
            produto.RetirarEstoque(quantidade);
            Produtos.Add(produto);
            Quantidade.Add(quantidade);
        }

        public void RemoverProduto(IProduto produto)
        {
            if (!Produtos.Contains(produto))
                throw new Exception();

            int index = Produtos.IndexOf(produto);

            Produtos.Remove(produto);
            Quantidade.RemoveAt(index);
        }

        public string Listar()
        {
            double valor = 0;
            string lista = "Itens carrinho:";

            for (int i = 0; i < Produtos.Count; i++)
            {
                lista += $"\n{i + 1}- {Produtos[i].Nome} - {Quantidade[i]} un.";
                valor += Produtos[i].Valor * Quantidade[i];
            }

            lista += $"\nTotal: {valor}";

            return lista;
        }
    }
}
