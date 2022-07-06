using Sem_6_Ex_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_6_Ex_3.Models
{
    public class Boletim
    {
        public IAluno Aluno { get; set; }
        public List<IAvaliacao> Avaliacoes { get; set; }
    }
}