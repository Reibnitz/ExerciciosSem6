using Sem_6_Ex_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_3.Models
{
    public class Avaliacao : IAvaliacao
    {
        public IDisciplina Disciplina { get; set; }
        public int NumeroAvaliacao { get; set; }
        public double Nota { get; set; }

        public Avaliacao(IDisciplina disciplina, int numeroAvaliacao, double nota)
        {
            Disciplina = disciplina;
            NumeroAvaliacao = numeroAvaliacao;
            Nota = nota;
        }
    }
}