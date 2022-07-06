using Sem_6_Ex_3.Interfaces;

namespace Sem_6_Ex_3.Models
{
    public class Aluno : IAluno
    {
        public string Nome { get; set; }
        public int NumeroChamada { get; set; }
        public List<IDisciplina> ListaDeDisciplinas{ get; }

        private List<IAvaliacao> _Boletim;
        public List<IAvaliacao> Boletim { 
            get
            {
                if (_Boletim == null) _Boletim = new List<IAvaliacao>();
                return _Boletim;
            }
            set
            {
                _Boletim = value;
            }
        }

        public Aluno(string nome, int numeroChamada, List<IDisciplina> listaDeDisciplinas)
        {
            Nome = nome;
            NumeroChamada = numeroChamada;
            ListaDeDisciplinas = listaDeDisciplinas;
        }

        public void AdicionarAvaliacao(IAvaliacao avaliacao)
        {
            if (!ListaDeDisciplinas.Contains(avaliacao.Disciplina)) throw new Exception("O aluno não está matriculado nesta disciplina");

            Boletim.Add(avaliacao);
        }
    }
}
