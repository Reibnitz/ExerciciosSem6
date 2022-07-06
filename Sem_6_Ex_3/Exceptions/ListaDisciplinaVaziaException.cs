using Sem_6_Ex_3.Interfaces;

namespace Sem_6_Ex_3.Exceptions
{
    public class ListaDisciplinaVaziaException : Exception
    {
        private const string MensagemErro = "ERRO - O aluno {0} não está matriculado em nenhuma disciplina";

        public ListaDisciplinaVaziaException(IAluno aluno) : base (string.Format(MensagemErro, aluno.Nome))
        {

        }
    }
}
