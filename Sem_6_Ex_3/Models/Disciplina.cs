using Sem_6_Ex_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_3.Models
{
    public class Disciplina : IDisciplina
    {
        public string Nome { get; set; }
        public int QuantidadeAvaliacoes { get; set; }

        public Disciplina(string nome, int quantidadeAvaliacoes)
        {
            Nome = nome;
            QuantidadeAvaliacoes = quantidadeAvaliacoes;
        }
    }
}
